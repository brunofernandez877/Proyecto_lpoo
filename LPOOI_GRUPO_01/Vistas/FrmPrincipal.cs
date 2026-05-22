using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmPrincipal : Form
    {

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducto frm = new FrmProducto();
            frm.Show();
        }

        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea cerrar la sesión actual?",
         "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                this.Close(); // Esto cierra el Menú Principal y devuelve el control al Login
            }
        }

        private void altaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente ventanaCliente = new FrmCliente();
            ventanaCliente.ShowDialog(); // Se abre como ventana emergente[cite: 1]
        }

        private void altaDeObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmObraSocial ventanaObraSocial = new FrmObraSocial();
            ventanaObraSocial.ShowDialog();
        }

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario ventanaUsuarios = new FrmUsuario();
            ventanaUsuarios.ShowDialog();
        }

        // Aquí irás agregando los eventos para abrir Clientes, Productos, etc.
    }
}
