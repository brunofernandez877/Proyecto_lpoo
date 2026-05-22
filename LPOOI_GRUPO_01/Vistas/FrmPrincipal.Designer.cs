namespace Vistas
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inquilinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeObraSocialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.inquilinoToolStripMenuItem,
            this.departamentoToolStripMenuItem,
            this.sistemaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(784, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.sistemaToolStripMenuItem.Text = "Productos";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.productosToolStripMenuItem.Text = "Alta de Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // inquilinoToolStripMenuItem
            // 
            this.inquilinoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeClientesToolStripMenuItem});
            this.inquilinoToolStripMenuItem.Name = "inquilinoToolStripMenuItem";
            this.inquilinoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.inquilinoToolStripMenuItem.Text = "Clientes";
            // 
            // altaDeClientesToolStripMenuItem
            // 
            this.altaDeClientesToolStripMenuItem.Name = "altaDeClientesToolStripMenuItem";
            this.altaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.altaDeClientesToolStripMenuItem.Text = "Alta de Clientes";
            this.altaDeClientesToolStripMenuItem.Click += new System.EventHandler(this.altaDeClientesToolStripMenuItem_Click);
            // 
            // departamentoToolStripMenuItem
            // 
            this.departamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeObraSocialToolStripMenuItem});
            this.departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            this.departamentoToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.departamentoToolStripMenuItem.Text = "Obras Sociales";
            // 
            // altaDeObraSocialToolStripMenuItem
            // 
            this.altaDeObraSocialToolStripMenuItem.Name = "altaDeObraSocialToolStripMenuItem";
            this.altaDeObraSocialToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.altaDeObraSocialToolStripMenuItem.Text = "Alta de Obra Social";
            this.altaDeObraSocialToolStripMenuItem.Click += new System.EventHandler(this.altaDeObraSocialToolStripMenuItem_Click);
            // 
            // sistemaToolStripMenuItem1
            // 
            this.sistemaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem2,
            this.gestionDeUsuariosToolStripMenuItem});
            this.sistemaToolStripMenuItem1.Name = "sistemaToolStripMenuItem1";
            this.sistemaToolStripMenuItem1.Size = new System.Drawing.Size(73, 24);
            this.sistemaToolStripMenuItem1.Text = "Sistema";
            // 
            // sistemaToolStripMenuItem2
            // 
            this.sistemaToolStripMenuItem2.Name = "sistemaToolStripMenuItem2";
            this.sistemaToolStripMenuItem2.Size = new System.Drawing.Size(209, 24);
            this.sistemaToolStripMenuItem2.Text = "Cerrar Sesion";
            this.sistemaToolStripMenuItem2.Click += new System.EventHandler(this.salirToolStripMenuItem2_Click);
            // 
            // gestionDeUsuariosToolStripMenuItem
            // 
            this.gestionDeUsuariosToolStripMenuItem.Name = "gestionDeUsuariosToolStripMenuItem";
            this.gestionDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.gestionDeUsuariosToolStripMenuItem.Text = "Gestion de Usuarios";
            this.gestionDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeUsuariosToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 452);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inquilinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem altaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeObraSocialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gestionDeUsuariosToolStripMenuItem;
    }
}