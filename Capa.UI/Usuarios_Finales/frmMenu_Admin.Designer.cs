namespace Capa.UI.Usuarios_Finales
{
    partial class frmMenu_Admin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu_Admin));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeSolicitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.librosPendientesDevolucionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosYEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosMasPrestadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.toolsMenu,
            this.windowsMenu,
            this.reporteToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(955, 32);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(73, 24);
            this.fileMenu.Text = "&Archivo";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.exitToolStripMenuItem.Text = "&Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsMenu.Image = global::Capa.UI.Properties.Resources.config;
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(133, 24);
            this.toolsMenu.Text = "&Herramientas";
            this.toolsMenu.Click += new System.EventHandler(this.toolsMenu_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.estudiantesToolStripMenuItem,
            this.librosToolStripMenuItem,
            this.autoresToolStripMenuItem,
            this.editorialToolStripMenuItem,
            this.tipoDeSolicitudToolStripMenuItem,
            this.agregarAutoresToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.optionsToolStripMenuItem.Text = "&Mantenimientos";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.estudiantesToolStripMenuItem.Text = "Estudiantes";
            this.estudiantesToolStripMenuItem.Click += new System.EventHandler(this.estudiantesToolStripMenuItem_Click);
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.librosToolStripMenuItem.Text = "Libros";
            this.librosToolStripMenuItem.Click += new System.EventHandler(this.librosToolStripMenuItem_Click);
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.autoresToolStripMenuItem.Text = "Autores";
            this.autoresToolStripMenuItem.Click += new System.EventHandler(this.autoresToolStripMenuItem_Click);
            // 
            // editorialToolStripMenuItem
            // 
            this.editorialToolStripMenuItem.Name = "editorialToolStripMenuItem";
            this.editorialToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.editorialToolStripMenuItem.Text = "Editorial";
            this.editorialToolStripMenuItem.Click += new System.EventHandler(this.editorialToolStripMenuItem_Click);
            // 
            // tipoDeSolicitudToolStripMenuItem
            // 
            this.tipoDeSolicitudToolStripMenuItem.Name = "tipoDeSolicitudToolStripMenuItem";
            this.tipoDeSolicitudToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.tipoDeSolicitudToolStripMenuItem.Text = "Tipo de Solicitud";
            this.tipoDeSolicitudToolStripMenuItem.Click += new System.EventHandler(this.tipoDeSolicitudToolStripMenuItem_Click);
            // 
            // agregarAutoresToolStripMenuItem
            // 
            this.agregarAutoresToolStripMenuItem.Name = "agregarAutoresToolStripMenuItem";
            this.agregarAutoresToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.agregarAutoresToolStripMenuItem.Text = "Agregar Autores";
            this.agregarAutoresToolStripMenuItem.Click += new System.EventHandler(this.agregarAutoresToolStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prestamosToolStripMenuItem,
            this.closeAllToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(90, 24);
            this.windowsMenu.Text = "&Ventanas";
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.prestamosToolStripMenuItem.Text = "&Prestamos";
            this.prestamosToolStripMenuItem.Click += new System.EventHandler(this.prestamosToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.closeAllToolStripMenuItem.Text = "C&errar todo";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteToolStripMenuItem1,
            this.librosPendientesDevolucionToolStripMenuItem,
            this.librosYEstudiantesToolStripMenuItem,
            this.librosMasPrestadosToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.reporteToolStripMenuItem.Text = "&Reportes";
            // 
            // reporteToolStripMenuItem1
            // 
            this.reporteToolStripMenuItem1.Name = "reporteToolStripMenuItem1";
            this.reporteToolStripMenuItem1.Size = new System.Drawing.Size(287, 24);
            this.reporteToolStripMenuItem1.Text = "Libros Prestados";
            this.reporteToolStripMenuItem1.Click += new System.EventHandler(this.reporteToolStripMenuItem1_Click);
            // 
            // librosPendientesDevolucionToolStripMenuItem
            // 
            this.librosPendientesDevolucionToolStripMenuItem.Name = "librosPendientesDevolucionToolStripMenuItem";
            this.librosPendientesDevolucionToolStripMenuItem.Size = new System.Drawing.Size(287, 24);
            this.librosPendientesDevolucionToolStripMenuItem.Text = "Libros Pendientes Devolucion";
            this.librosPendientesDevolucionToolStripMenuItem.Click += new System.EventHandler(this.librosPendientesDevolucionToolStripMenuItem_Click);
            // 
            // librosYEstudiantesToolStripMenuItem
            // 
            this.librosYEstudiantesToolStripMenuItem.Name = "librosYEstudiantesToolStripMenuItem";
            this.librosYEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(287, 24);
            this.librosYEstudiantesToolStripMenuItem.Text = "Libros y Estudiantes";
            this.librosYEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.librosYEstudiantesToolStripMenuItem_Click);
            // 
            // librosMasPrestadosToolStripMenuItem
            // 
            this.librosMasPrestadosToolStripMenuItem.Name = "librosMasPrestadosToolStripMenuItem";
            this.librosMasPrestadosToolStripMenuItem.Size = new System.Drawing.Size(287, 24);
            this.librosMasPrestadosToolStripMenuItem.Text = "Libros más Prestados";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 381);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(3, 0, 28, 0);
            this.statusStrip.Size = new System.Drawing.Size(955, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // frmMenu_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(955, 403);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu del Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_Admin_FormClosed);
            this.Load += new System.EventHandler(this.frmMenu_Admin_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeSolicitudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAutoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem librosPendientesDevolucionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosYEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosMasPrestadosToolStripMenuItem;
    }
}



