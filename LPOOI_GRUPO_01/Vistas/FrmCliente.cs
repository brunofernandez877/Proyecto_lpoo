using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void limpiarCampos()
        {
            txtDNI.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtCuitOS.Clear();
            txtNroCarnet.Clear();
            txtDNI.Focus(); // Deja el cursor listo para el próximo DNI
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            // LLAMADA A LA VALIDACIÓN
            if (!ValidarCampos()) return; // Si la función devuelve 'false', el código se detiene acá
        // 1. Mensaje de confirmación previo (Punto 8)
        DialogResult result = MessageBox.Show("¿Desea registrar este nuevo cliente?", 
            "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 2. Instanciamos la clase del proyecto ClasesBase
                Cliente oCliente = new Cliente();

                // 3. Cargamos las propiedades del objeto con los textos de los controles
                oCliente.Cli_DNI = txtDNI.Text;
                oCliente.Cli_Apellido = txtApellido.Text;
                oCliente.Cli_Nombre = txtNombre.Text;
                oCliente.Cli_Direccion = txtDireccion.Text;
                oCliente.OS_CUIT = txtCuitOS.Text;
                oCliente.Cli_NroCarnet = txtNroCarnet.Text;

                // 4. Verificación visual: Imprimimos los valores (Punto 8)
                MessageBox.Show("Cliente almacenado en el objeto con éxito:" +
                                "\nNombre Completo: " + oCliente.Cli_Apellido + ", " + oCliente.Cli_Nombre +
                                "\nDNI: " + oCliente.Cli_DNI +
                                "\nObra Social (CUIT): " + oCliente.OS_CUIT, 
                                "Alta de Cliente");

                // 5. Limpiamos para el próximo ingreso
                limpiarCampos();
            }
        }

        // Función para validar que ningún campo esté vacío
        private bool ValidarCampos()
        {
            foreach (Control c in this.Controls)
            {
                // Solo revisamos los TextBox que están a la vista
                if (c is TextBox && string.IsNullOrWhiteSpace(c.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de continuar.",
                        "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    c.Focus(); // Pone el cursor en el campo vacío
                    return false; // Corta la validación porque encontró uno vacío
                }
            }
            return true; // Todos los campos están completos
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
}
}
