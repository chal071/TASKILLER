namespace TASKILLER
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.panelInicio = new System.Windows.Forms.Panel();
            this.labelUltimosProyectos = new System.Windows.Forms.Label();
            this.labelHoy = new System.Windows.Forms.Label();
            this.labelHaceUnaSemana = new System.Windows.Forms.Label();
            this.flowLayoutPanelHoy = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelSemana = new System.Windows.Forms.FlowLayoutPanel();
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
            this.panelInicio.SuspendLayout();
            this.toolStripInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInicio
            // 
            this.panelInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelInicio.BackColor = System.Drawing.SystemColors.Control;
            this.panelInicio.Controls.Add(this.labelUltimosProyectos);
            this.panelInicio.Controls.Add(this.labelHoy);
            this.panelInicio.Controls.Add(this.labelHaceUnaSemana);
            this.panelInicio.Controls.Add(this.flowLayoutPanelHoy);
            this.panelInicio.Controls.Add(this.flowLayoutPanelSemana);
            this.panelInicio.Location = new System.Drawing.Point(0, 30);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(941, 455);
            this.panelInicio.TabIndex = 0;
            // 
            // labelUltimosProyectos
            // 
            this.labelUltimosProyectos.AutoSize = true;
            this.labelUltimosProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUltimosProyectos.Location = new System.Drawing.Point(86, 8);
            this.labelUltimosProyectos.Name = "labelUltimosProyectos";
            this.labelUltimosProyectos.Size = new System.Drawing.Size(270, 16);
            this.labelUltimosProyectos.TabIndex = 10;
            this.labelUltimosProyectos.Text = "Proyectos con fecha límite temprana...";
            // 
            // labelHoy
            // 
            this.labelHoy.AutoSize = true;
            this.labelHoy.Location = new System.Drawing.Point(93, 56);
            this.labelHoy.Name = "labelHoy";
            this.labelHoy.Size = new System.Drawing.Size(35, 16);
            this.labelHoy.TabIndex = 11;
            this.labelHoy.Text = "Hoy:";
            // 
            // labelHaceUnaSemana
            // 
            this.labelHaceUnaSemana.AutoSize = true;
            this.labelHaceUnaSemana.Location = new System.Drawing.Point(86, 248);
            this.labelHaceUnaSemana.Name = "labelHaceUnaSemana";
            this.labelHaceUnaSemana.Size = new System.Drawing.Size(166, 16);
            this.labelHaceUnaSemana.TabIndex = 12;
            this.labelHaceUnaSemana.Text = "En menos de una semana:";
            // 
            // flowLayoutPanelHoy
            // 
            this.flowLayoutPanelHoy.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanelHoy.Location = new System.Drawing.Point(89, 75);
            this.flowLayoutPanelHoy.Name = "flowLayoutPanelHoy";
            this.flowLayoutPanelHoy.Size = new System.Drawing.Size(840, 147);
            this.flowLayoutPanelHoy.TabIndex = 13;
            // 
            // flowLayoutPanelSemana
            // 
            this.flowLayoutPanelSemana.Location = new System.Drawing.Point(89, 271);
            this.flowLayoutPanelSemana.Name = "flowLayoutPanelSemana";
            this.flowLayoutPanelSemana.Size = new System.Drawing.Size(840, 147);
            this.flowLayoutPanelSemana.TabIndex = 14;
            // 
            // toolStripInicio
            // 
            this.toolStripInicio.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripInicio.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.btnUsuario,
            this.btnTaskiller});
            this.toolStripInicio.Location = new System.Drawing.Point(0, 0);
            this.toolStripInicio.Name = "toolStripInicio";
            this.toolStripInicio.Size = new System.Drawing.Size(941, 27);
            this.toolStripInicio.TabIndex = 9;
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
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 484);
            this.Controls.Add(this.toolStripInicio);
            this.Controls.Add(this.panelInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormInicio";
            this.Text = "TASKILLER - Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelInicio.ResumeLayout(false);
            this.panelInicio.PerformLayout();
            this.toolStripInicio.ResumeLayout(false);
            this.toolStripInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelInicio;
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
        private System.Windows.Forms.Label labelUltimosProyectos;
        private System.Windows.Forms.Label labelHoy;
        private System.Windows.Forms.Label labelHaceUnaSemana;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHoy;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSemana;
    }
}

