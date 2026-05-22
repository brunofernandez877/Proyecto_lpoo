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
    public partial class FrmObraSocial : Form
    {
        public FrmObraSocial()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // LLAMADA A LA VALIDACIÓN
            if (!ValidarCampos()) return; // Si la función devuelve 'false', el código se detiene acá

            // 1. Mensaje de confirmación previo (Punto 8)
            DialogResult result = MessageBox.Show("¿Desea registrar esta nueva Obra Social?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 2. Instanciamos la clase del proyecto ClasesBase
                ObraSocial oObraSocial = new ObraSocial();

                // 3. Cargamos las propiedades del objeto con los textos de los controles
                oObraSocial.OS_CUIT = txtCUIT.Text;
                oObraSocial.OS_RazonSocial = txtRazonSocial.Text;
                oObraSocial.OS_Direccion = txtDireccion.Text;
                oObraSocial.OS_Telefono = txtTelefono.Text;

                // 4. Verificación visual: Imprimimos los valores (Punto 8)
                MessageBox.Show("Obra Social almacenado en el objeto con éxito:" +
                                "\nOS_CUIT: " + oObraSocial.OS_CUIT +
                                "\nOS_RazonSocial: " + oObraSocial.OS_RazonSocial +
                                "\nOS_Direccion: " + oObraSocial.OS_Direccion + 
                                "\nOS_Telefono:" + oObraSocial.OS_Telefono,
                                "Alta de Obra Social");

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

        private void limpiarCampos()
        {
            txtCUIT.Clear();
            txtRazonSocial.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCUIT.Focus(); // Deja el cursor listo para el próximo DNI
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
