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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            // LLAMADA A LA VALIDACIÓN
            if (!ValidarCampos()) return; // Si la función devuelve 'false', el código se detiene acá

            // 1. Punto 8: Mensaje de CONFIRMACIÓN PREVIO
            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea registrar este producto?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.No) return; // Si dice que no, salimos del método

            // 2. Validación de datos (Parsing)
            decimal precioAux;
            if (!decimal.TryParse(txtPrecio.Text, out precioAux))
            {
                MessageBox.Show("Por favor, ingrese un precio numérico válido.", "Error de formato");
                return;
            }

            // 3. Creación del objeto y asignación
            Producto oProducto = new Producto();
            oProducto.Prod_Codigo = txtCodigo.Text;
            oProducto.Prod_Categoria = txtCategoria.Text;
            oProducto.Prod_Descripcion = txtDescripcion.Text;
            oProducto.Prod_Precio = precioAux;

            // 4. Punto 8: Imprimir valores para verificar almacenamiento
            MessageBox.Show("Datos almacenados con éxito en el objeto:" +
                            "\nCódigo: " + oProducto.Prod_Codigo +
                            "\nCategoría: " + oProducto.Prod_Categoria +
                            "\nDescripción: " + oProducto.Prod_Descripcion +
                            "\nPrecio: $" + oProducto.Prod_Precio,
                            "Alta Exitosa");

            // 5. Limpiar campos para un nuevo ingreso
            limpiarCampos();
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

        // Botón para salir de la ventana actual
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Método para vaciar los TextBox
        private void limpiarCampos()
        {
            txtCodigo.Text = "";
            txtCategoria.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCodigo.Focus(); // Pone el cursor de nuevo en el primer campo
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {

        }
    }
}