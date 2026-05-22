using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas {
    public partial class FrmUsuario : Form {
        public FrmUsuario() { InitializeComponent(); }

        private void FrmUsuario_Load(object sender, EventArgs e) {
            // Cargar ComboBox
            cmbRol.DisplayMember = "Texto";
            cmbRol.ValueMember = "Valor";
            cmbRol.Items.Add(new { Texto = "Administrador", Valor = 1 });
            cmbRol.Items.Add(new { Texto = "Operador", Valor = 2 });
            cmbRol.Items.Add(new { Texto = "Auditor", Valor = 3 });
            
            // Cargar Grilla inicial
            dgvUsuarios.DataSource = TrabajarUsuario.list_usuarios();
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            Usuario u = new Usuario {
                Usu_NombreUsuario = txtUser.Text,
                Usu_Contraseña = txtPass.Text,
                Usu_ApellidoNombre = txtNombre.Text,
                Rol_Codigo = (int)cmbRol.SelectedValue
            };
            TrabajarUsuario.insert_usuario(u);
            MessageBox.Show("Guardado!");
            dgvUsuarios.DataSource = TrabajarUsuario.list_usuarios(); // Actualizar
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            // Aquí se aplica el LIKE del TP
            dgvUsuarios.DataSource = TrabajarUsuario.search_usuarios(txtBuscar.Text);
        }
    }
}

