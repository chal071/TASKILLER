namespace TASKILLER
{
    partial class FormListaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaUsuarios));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripInicio = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNuevoProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsuario = new System.Windows.Forms.ToolStripButton();
            this.btnTaskiller = new System.Windows.Forms.ToolStripButton();
            this.labelListaDeUsuarios = new System.Windows.Forms.Label();
            this.dataGridViewListaUsuarios = new System.Windows.Forms.DataGridView();
            this.toolStripLabelNombre = new System.Windows.Forms.ToolStripLabel();
            this.tableLayoutPanel.SuspendLayout();
            this.toolStripInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.toolStripInicio, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelListaDeUsuarios, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.dataGridViewListaUsuarios, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1090, 596);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // toolStripInicio
            // 
            this.toolStripInicio.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripInicio.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.btnUsuario,
            this.btnTaskiller,
            this.toolStripLabelNombre});
            this.toolStripInicio.Location = new System.Drawing.Point(0, 0);
            this.toolStripInicio.Name = "toolStripInicio";
            this.toolStripInicio.Size = new System.Drawing.Size(1090, 27);
            this.toolStripInicio.TabIndex = 7;
            this.toolStripInicio.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.proyectosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.guardarDatosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inicioToolStripMenuItem.Image")));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // proyectosToolStripMenuItem
            // 
            this.proyectosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearNuevoProyectoToolStripMenuItem});
            this.proyectosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("proyectosToolStripMenuItem.Image")));
            this.proyectosToolStripMenuItem.Name = "proyectosToolStripMenuItem";
            this.proyectosToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.proyectosToolStripMenuItem.Text = "Proyectos";
            this.proyectosToolStripMenuItem.Click += new System.EventHandler(this.proyectosToolStripMenuItem_Click);
            // 
            // crearNuevoProyectoToolStripMenuItem
            // 
            this.crearNuevoProyectoToolStripMenuItem.Name = "crearNuevoProyectoToolStripMenuItem";
            this.crearNuevoProyectoToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.crearNuevoProyectoToolStripMenuItem.Text = "Crear nuevo proyecto";
            this.crearNuevoProyectoToolStripMenuItem.Click += new System.EventHandler(this.crearNuevoProyectoToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearNuevoUsuarioToolStripMenuItem});
            this.usuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem.Image")));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // crearNuevoUsuarioToolStripMenuItem
            // 
            this.crearNuevoUsuarioToolStripMenuItem.Name = "crearNuevoUsuarioToolStripMenuItem";
            this.crearNuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.crearNuevoUsuarioToolStripMenuItem.Text = "Crear nuevo usuario";
            this.crearNuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.crearNuevoUsuarioToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rolesToolStripMenuItem.Image")));
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // guardarDatosToolStripMenuItem
            // 
            this.guardarDatosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarDatosToolStripMenuItem.Image")));
            this.guardarDatosToolStripMenuItem.Name = "guardarDatosToolStripMenuItem";
            this.guardarDatosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarDatosToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.guardarDatosToolStripMenuItem.Text = "Guardar datos";
            this.guardarDatosToolStripMenuItem.Click += new System.EventHandler(this.guardarDatosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(29, 24);
            this.btnUsuario.Text = "Usuario";
            // 
            // btnTaskiller
            // 
            this.btnTaskiller.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTaskiller.Image = ((System.Drawing.Image)(resources.GetObject("btnTaskiller.Image")));
            this.btnTaskiller.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTaskiller.Name = "btnTaskiller";
            this.btnTaskiller.Size = new System.Drawing.Size(29, 24);
            this.btnTaskiller.Text = "TaskillerLogo";
            // 
            // labelListaDeUsuarios
            // 
            this.labelListaDeUsuarios.AutoSize = true;
            this.labelListaDeUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelListaDeUsuarios.Location = new System.Drawing.Point(2, 59);
            this.labelListaDeUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelListaDeUsuarios.Name = "labelListaDeUsuarios";
            this.labelListaDeUsuarios.Size = new System.Drawing.Size(1086, 59);
            this.labelListaDeUsuarios.TabIndex = 0;
            this.labelListaDeUsuarios.Text = "Lista de Usuarios";
            this.labelListaDeUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewListaUsuarios
            // 
            this.dataGridViewListaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListaUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewListaUsuarios.Location = new System.Drawing.Point(2, 120);
            this.dataGridViewListaUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewListaUsuarios.Name = "dataGridViewListaUsuarios";
            this.dataGridViewListaUsuarios.RowHeadersVisible = false;
            this.dataGridViewListaUsuarios.RowHeadersWidth = 82;
            this.dataGridViewListaUsuarios.RowTemplate.Height = 33;
            this.dataGridViewListaUsuarios.Size = new System.Drawing.Size(1086, 474);
            this.dataGridViewListaUsuarios.TabIndex = 1;
            // 
            // toolStripLabelNombre
            // 
            this.toolStripLabelNombre.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelNombre.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.toolStripLabelNombre.Name = "toolStripLabelNombre";
            this.toolStripLabelNombre.Size = new System.Drawing.Size(97, 24);
            this.toolStripLabelNombre.Text = "Nombre User";
            // 
            // FormListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 596);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormListaUsuarios";
            this.Text = "FormListaUsuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.toolStripInicio.ResumeLayout(false);
            this.toolStripInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelListaDeUsuarios;
        private System.Windows.Forms.DataGridView dataGridViewListaUsuarios;
        private System.Windows.Forms.ToolStrip toolStripInicio;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNuevoProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnUsuario;
        private System.Windows.Forms.ToolStripButton btnTaskiller;
        private System.Windows.Forms.ToolStripLabel toolStripLabelNombre;
    }
}