using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase; // Importante para reconocer la clase Usuario

namespace Vistas
{
    public partial class FrmLogin : Form
    {

        // Creamos la lista con los 3 usuarios que pide el profe
        List<Usuario> listaUsuarios = new List<Usuario>();

        public FrmLogin()
        {
            InitializeComponent();
            CargarUsuariosPrueba();
        }

        private void CargarUsuariosPrueba()
        {
            // Punto 6: Cargamos 3 usuarios de ejemplo
            listaUsuarios.Add(new Usuario { Usu_NombreUsuario = "admin", Usu_Contraseña = "123", Usu_ApellidoNombre = "Admin Sistema" });
            listaUsuarios.Add(new Usuario { Usu_NombreUsuario = "operador", Usu_Contraseña = "456", Usu_ApellidoNombre = "Juan Operador" });
            listaUsuarios.Add(new Usuario { Usu_NombreUsuario = "auditor", Usu_Contraseña = "789", Usu_ApellidoNombre = "Ana Auditora" });
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // LLAMADA A LA VALIDACIÓN
            if (!ValidarCampos()) return; // Si la función devuelve 'false', el código se detiene acá
            bool loginValido = false;


            // Recorremos la lista para ver si lo que escribiste es correcto
            foreach (Usuario usu in listaUsuarios)
            {
                if (usu.Usu_NombreUsuario == txtUsuario.Text && usu.Usu_Contraseña == txtPassword.Text)
                {
                    loginValido = true;
                    break;
                }
            }

            if (loginValido)
            {
                FrmPrincipal principal = new FrmPrincipal();

                this.Hide(); // Escondemos el Login [Punto 6]

                principal.ShowDialog(); // Abrimos el Principal de forma modal [Punto 7]

                // Cuando el Principal se cierre (this.Close()), el código seguirá aquí:
                this.Show(); // Mostramos el Login de nuevo

                // Opcional: Limpiar los campos de contraseña para el próximo ingreso
                txtUsuario.Clear();
                txtPassword.Clear();
                txtUsuario.Focus();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error");
            }
        }

        private void btnIngresar_MouseHover(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.LightBlue;
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.BackColor = SystemColors.Control;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

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

        private void btnSalirSistema_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea salir del sistema?",
        "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit(); // Cierra toda la aplicación
            }
        }
    }
}
       