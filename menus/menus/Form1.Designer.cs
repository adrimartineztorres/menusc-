namespace menus
{
    partial class mMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mMenuPrincipal));
            this.mMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mConfiguración = new System.Windows.Forms.ToolStripMenuItem();
            this.mArchivosIVA = new System.Windows.Forms.ToolStripMenuItem();
            this.mArchivoProvincias = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mArchivoImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mClientesClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mClientesAlbaranes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuProductos = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.mMenu.SuspendLayout();
            this.tsMenuProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // mMenu
            // 
            this.mMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.mClientes});
            this.mMenu.Location = new System.Drawing.Point(0, 0);
            this.mMenu.Name = "mMenu";
            this.mMenu.Size = new System.Drawing.Size(521, 24);
            this.mMenu.TabIndex = 0;
            this.mMenu.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mConfiguración,
            this.toolStripSeparator2,
            this.mArchivoImprimir,
            this.toolStripSeparator4,
            this.mArchivoSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // mConfiguración
            // 
            this.mConfiguración.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArchivosIVA,
            this.mArchivoProvincias});
            this.mConfiguración.Name = "mConfiguración";
            this.mConfiguración.Size = new System.Drawing.Size(180, 22);
            this.mConfiguración.Text = "Configuración";
            // 
            // mArchivosIVA
            // 
            this.mArchivosIVA.Name = "mArchivosIVA";
            this.mArchivosIVA.Size = new System.Drawing.Size(128, 22);
            this.mArchivosIVA.Text = "IVA";
            // 
            // mArchivoProvincias
            // 
            this.mArchivoProvincias.Name = "mArchivoProvincias";
            this.mArchivoProvincias.Size = new System.Drawing.Size(128, 22);
            this.mArchivoProvincias.Text = "Provincias";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // mArchivoImprimir
            // 
            this.mArchivoImprimir.Name = "mArchivoImprimir";
            this.mArchivoImprimir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mArchivoImprimir.Size = new System.Drawing.Size(180, 22);
            this.mArchivoImprimir.Text = "Imprimir";
            this.mArchivoImprimir.Click += new System.EventHandler(this.mArchivoImprimir_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // mArchivoSalir
            // 
            this.mArchivoSalir.Name = "mArchivoSalir";
            this.mArchivoSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.mArchivoSalir.Size = new System.Drawing.Size(180, 22);
            this.mArchivoSalir.Text = "Salir";
            this.mArchivoSalir.Click += new System.EventHandler(this.mArchivoSalir_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mProductos});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // mProductos
            // 
            this.mProductos.Name = "mProductos";
            this.mProductos.Size = new System.Drawing.Size(180, 22);
            this.mProductos.Text = "Productos";
            // 
            // mClientes
            // 
            this.mClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mClientesClientes,
            this.toolStripSeparator1,
            this.mClientesAlbaranes});
            this.mClientes.Name = "mClientes";
            this.mClientes.Size = new System.Drawing.Size(61, 20);
            this.mClientes.Text = "Clientes";
            // 
            // mClientesClientes
            // 
            this.mClientesClientes.Name = "mClientesClientes";
            this.mClientesClientes.Size = new System.Drawing.Size(180, 22);
            this.mClientesClientes.Text = "Clientes";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mClientesAlbaranes
            // 
            this.mClientesAlbaranes.Name = "mClientesAlbaranes";
            this.mClientesAlbaranes.Size = new System.Drawing.Size(180, 22);
            this.mClientesAlbaranes.Text = "Albaranes";
            // 
            // tsMenuProductos
            // 
            this.tsMenuProductos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton3});
            this.tsMenuProductos.Location = new System.Drawing.Point(0, 24);
            this.tsMenuProductos.Name = "tsMenuProductos";
            this.tsMenuProductos.Size = new System.Drawing.Size(521, 25);
            this.tsMenuProductos.TabIndex = 2;
            this.tsMenuProductos.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.mArchivoSalir_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // mMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 261);
            this.Controls.Add(this.tsMenuProductos);
            this.Controls.Add(this.mMenu);
            this.MainMenuStrip = this.mMenu;
            this.Name = "mMenuPrincipal";
            this.Text = "MenuPrincipal";
            this.mMenu.ResumeLayout(false);
            this.mMenu.PerformLayout();
            this.tsMenuProductos.ResumeLayout(false);
            this.tsMenuProductos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mConfiguración;
        private System.Windows.Forms.ToolStripMenuItem mArchivosIVA;
        private System.Windows.Forms.ToolStripMenuItem mArchivoProvincias;
        private System.Windows.Forms.ToolStripMenuItem mArchivoImprimir;
        private System.Windows.Forms.ToolStripMenuItem mArchivoSalir;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mProductos;
        private System.Windows.Forms.ToolStripMenuItem mClientes;
        private System.Windows.Forms.ToolStripMenuItem mClientesClientes;
        private System.Windows.Forms.ToolStripMenuItem mClientesAlbaranes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip tsMenuProductos;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}

