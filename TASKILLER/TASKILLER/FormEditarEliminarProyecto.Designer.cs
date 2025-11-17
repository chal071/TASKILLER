namespace TASKILLER
{
    partial class FormEditarEliminarProyecto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarEliminarProyecto));
            this.panelInfo = new System.Windows.Forms.Panel();
            this.buttonEditarProyecto = new System.Windows.Forms.Button();
            this.dateTimePickerFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.buttonEliminarProyecto = new System.Windows.Forms.Button();
            this.labelFechaFinal = new System.Windows.Forms.Label();
            this.richTextBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelCuentanosProyecto = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.toolStripInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelInfo.Controls.Add(this.buttonEditarProyecto);
            this.panelInfo.Controls.Add(this.dateTimePickerFechaFinal);
            this.panelInfo.Controls.Add(this.dateTimePickerFechaInicio);
            this.panelInfo.Controls.Add(this.labelEstado);
            this.panelInfo.Controls.Add(this.labelDescripcion);
            this.panelInfo.Controls.Add(this.textBoxTitulo);
            this.panelInfo.Controls.Add(this.pictureBoxLogo);
            this.panelInfo.Controls.Add(this.labelFechaInicio);
            this.panelInfo.Controls.Add(this.buttonEliminarProyecto);
            this.panelInfo.Controls.Add(this.labelFechaFinal);
            this.panelInfo.Controls.Add(this.richTextBoxDescripcion);
            this.panelInfo.Controls.Add(this.comboBoxEstado);
            this.panelInfo.Controls.Add(this.labelTitulo);
            this.panelInfo.Controls.Add(this.labelCuentanosProyecto);
            this.panelInfo.Location = new System.Drawing.Point(24, 133);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(815, 418);
            this.panelInfo.TabIndex = 14;
            // 
            // buttonEditarProyecto
            // 
            this.buttonEditarProyecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditarProyecto.Location = new System.Drawing.Point(391, 365);
            this.buttonEditarProyecto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditarProyecto.Name = "buttonEditarProyecto";
            this.buttonEditarProyecto.Size = new System.Drawing.Size(188, 51);
            this.buttonEditarProyecto.TabIndex = 15;
            this.buttonEditarProyecto.Text = "Guardar proyecto";
            this.buttonEditarProyecto.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFechaFinal
            // 
            this.dateTimePickerFechaFinal.Location = new System.Drawing.Point(481, 172);
            this.dateTimePickerFechaFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFechaFinal.Name = "dateTimePickerFechaFinal";
            this.dateTimePickerFechaFinal.Size = new System.Drawing.Size(329, 22);
            this.dateTimePickerFechaFinal.TabIndex = 14;
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(480, 106);
            this.dateTimePickerFechaInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(329, 22);
            this.dateTimePickerFechaInicio.TabIndex = 13;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(477, 217);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(53, 16);
            this.labelEstado.TabIndex = 9;
            this.labelEstado.Text = "Estado:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(-2, 274);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(82, 16);
            this.labelDescripcion.TabIndex = 12;
            this.labelDescripcion.Text = "Descripción:";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(-1, 211);
            this.textBoxTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(315, 22);
            this.textBoxTitulo.TabIndex = 2;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::TASKILLER.Properties.Resources.LOGO;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 2);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(176, 157);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Location = new System.Drawing.Point(475, 84);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(101, 16);
            this.labelFechaInicio.TabIndex = 8;
            this.labelFechaInicio.Text = "Fecha de inicio:";
            // 
            // buttonEliminarProyecto
            // 
            this.buttonEliminarProyecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminarProyecto.Location = new System.Drawing.Point(617, 365);
            this.buttonEliminarProyecto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEliminarProyecto.Name = "buttonEliminarProyecto";
            this.buttonEliminarProyecto.Size = new System.Drawing.Size(193, 51);
            this.buttonEliminarProyecto.TabIndex = 6;
            this.buttonEliminarProyecto.Text = "Eliminar proyecto";
            this.buttonEliminarProyecto.UseVisualStyleBackColor = true;
            // 
            // labelFechaFinal
            // 
            this.labelFechaFinal.AutoSize = true;
            this.labelFechaFinal.Location = new System.Drawing.Point(478, 150);
            this.labelFechaFinal.Name = "labelFechaFinal";
            this.labelFechaFinal.Size = new System.Drawing.Size(75, 16);
            this.labelFechaFinal.TabIndex = 10;
            this.labelFechaFinal.Text = "Fecha final:";
            // 
            // richTextBoxDescripcion
            // 
            this.richTextBoxDescripcion.Location = new System.Drawing.Point(1, 305);
            this.richTextBoxDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            this.richTextBoxDescripcion.Size = new System.Drawing.Size(313, 111);
            this.richTextBoxDescripcion.TabIndex = 11;
            this.richTextBoxDescripcion.Text = "";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(481, 236);
            this.comboBoxEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(329, 24);
            this.comboBoxEstado.TabIndex = 5;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(-4, 188);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(43, 16);
            this.labelTitulo.TabIndex = 7;
            this.labelTitulo.Text = "Título:";
            // 
            // labelCuentanosProyecto
            // 
            this.labelCuentanosProyecto.AutoSize = true;
            this.labelCuentanosProyecto.Location = new System.Drawing.Point(236, 0);
            this.labelCuentanosProyecto.MaximumSize = new System.Drawing.Size(600, 0);
            this.labelCuentanosProyecto.Name = "labelCuentanosProyecto";
            this.labelCuentanosProyecto.Size = new System.Drawing.Size(187, 16);
            this.labelCuentanosProyecto.TabIndex = 1;
            this.labelCuentanosProyecto.Text = "Cuéntanos sobre tu proyecto...";
            this.labelCuentanosProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.toolStripInicio.Size = new System.Drawing.Size(869, 27);
            this.toolStripInicio.TabIndex = 15;
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
            this.crearNuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            // FormEditarEliminarProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(869, 562);
            this.Controls.Add(this.toolStripInicio);
            this.Controls.Add(this.panelInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEditarEliminarProyecto";
            this.Text = "¡Edita tu proyecto!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.toolStripInicio.ResumeLayout(false);
            this.toolStripInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFinal;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicio;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Button buttonEliminarProyecto;
        private System.Windows.Forms.Label labelFechaFinal;
        private System.Windows.Forms.RichTextBox richTextBoxDescripcion;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelCuentanosProyecto;
        private System.Windows.Forms.Button buttonEditarProyecto;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
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
    }
}