namespace TASKILLER
{
    partial class FormListaTareas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaTareas));
            this.grid = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripInicio = new System.Windows.Forms.ToolStrip();
            this.flowLayoutPanelBloqueado = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelRevisado = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelEntregado = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelEnProgreso = new System.Windows.Forms.FlowLayoutPanel();
            this.labelBloqueado = new System.Windows.Forms.Label();
            this.labelRevisado = new System.Windows.Forms.Label();
            this.labelEntregado = new System.Windows.Forms.Label();
            this.labelEnProgreso = new System.Windows.Forms.Label();
            this.labelTarea = new System.Windows.Forms.Label();
            this.dataGridViewTareas = new System.Windows.Forms.DataGridView();
            this.labelPorComenzar = new System.Windows.Forms.Label();
            this.flowLayoutPanelPorComenzar = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNuevoProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsuario = new System.Windows.Forms.ToolStripButton();
            this.btnTaskiller = new System.Windows.Forms.ToolStripButton();
            this.buttonAnadirTarea = new System.Windows.Forms.Button();
            this.grid.SuspendLayout();
            this.toolStripInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.BackColor = System.Drawing.Color.White;
            this.grid.ColumnCount = 7;
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.grid.Controls.Add(this.toolStripInicio, 0, 0);
            this.grid.Controls.Add(this.flowLayoutPanelBloqueado, 6, 2);
            this.grid.Controls.Add(this.flowLayoutPanelRevisado, 5, 2);
            this.grid.Controls.Add(this.flowLayoutPanelEntregado, 4, 2);
            this.grid.Controls.Add(this.flowLayoutPanelEnProgreso, 3, 2);
            this.grid.Controls.Add(this.labelBloqueado, 6, 1);
            this.grid.Controls.Add(this.labelRevisado, 5, 1);
            this.grid.Controls.Add(this.labelEntregado, 4, 1);
            this.grid.Controls.Add(this.labelEnProgreso, 3, 1);
            this.grid.Controls.Add(this.labelTarea, 0, 1);
            this.grid.Controls.Add(this.buttonAnadirTarea, 1, 1);
            this.grid.Controls.Add(this.dataGridViewTareas, 0, 2);
            this.grid.Controls.Add(this.labelPorComenzar, 2, 1);
            this.grid.Controls.Add(this.flowLayoutPanelPorComenzar, 2, 2);
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Name = "grid";
            this.grid.RowCount = 3;
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.997906F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.000154F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.00194F));
            this.grid.Size = new System.Drawing.Size(1634, 969);
            this.grid.TabIndex = 0;
            // 
            // toolStripInicio
            // 
            this.grid.SetColumnSpan(this.toolStripInicio, 7);
            this.toolStripInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripInicio.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripInicio.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.btnUsuario,
            this.btnTaskiller});
            this.toolStripInicio.Location = new System.Drawing.Point(0, 0);
            this.toolStripInicio.Name = "toolStripInicio";
            this.toolStripInicio.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStripInicio.Size = new System.Drawing.Size(1634, 48);
            this.toolStripInicio.TabIndex = 20;
            this.toolStripInicio.Text = "toolStrip1";
            // 
            // flowLayoutPanelBloqueado
            // 
            this.flowLayoutPanelBloqueado.AllowDrop = true;
            this.flowLayoutPanelBloqueado.AutoScroll = true;
            this.flowLayoutPanelBloqueado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanelBloqueado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBloqueado.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelBloqueado.Location = new System.Drawing.Point(1390, 145);
            this.flowLayoutPanelBloqueado.Name = "flowLayoutPanelBloqueado";
            this.flowLayoutPanelBloqueado.Size = new System.Drawing.Size(241, 821);
            this.flowLayoutPanelBloqueado.TabIndex = 18;
            this.flowLayoutPanelBloqueado.WrapContents = false;
            // 
            // flowLayoutPanelRevisado
            // 
            this.flowLayoutPanelRevisado.AllowDrop = true;
            this.flowLayoutPanelRevisado.AutoScroll = true;
            this.flowLayoutPanelRevisado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanelRevisado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelRevisado.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelRevisado.Location = new System.Drawing.Point(1146, 147);
            this.flowLayoutPanelRevisado.Name = "flowLayoutPanelRevisado";
            this.flowLayoutPanelRevisado.Size = new System.Drawing.Size(239, 819);
            this.flowLayoutPanelRevisado.TabIndex = 17;
            this.flowLayoutPanelRevisado.WrapContents = false;
            // 
            // flowLayoutPanelEntregado
            // 
            this.flowLayoutPanelEntregado.AllowDrop = true;
            this.flowLayoutPanelEntregado.AutoScroll = true;
            this.flowLayoutPanelEntregado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanelEntregado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelEntregado.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelEntregado.Location = new System.Drawing.Point(901, 147);
            this.flowLayoutPanelEntregado.Name = "flowLayoutPanelEntregado";
            this.flowLayoutPanelEntregado.Size = new System.Drawing.Size(239, 819);
            this.flowLayoutPanelEntregado.TabIndex = 16;
            this.flowLayoutPanelEntregado.WrapContents = false;
            // 
            // flowLayoutPanelEnProgreso
            // 
            this.flowLayoutPanelEnProgreso.AllowDrop = true;
            this.flowLayoutPanelEnProgreso.AutoScroll = true;
            this.flowLayoutPanelEnProgreso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanelEnProgreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelEnProgreso.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelEnProgreso.Location = new System.Drawing.Point(656, 147);
            this.flowLayoutPanelEnProgreso.Name = "flowLayoutPanelEnProgreso";
            this.flowLayoutPanelEnProgreso.Size = new System.Drawing.Size(239, 819);
            this.flowLayoutPanelEnProgreso.TabIndex = 15;
            this.flowLayoutPanelEnProgreso.WrapContents = false;
            // 
            // labelBloqueado
            // 
            this.labelBloqueado.AutoSize = true;
            this.labelBloqueado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelBloqueado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBloqueado.Location = new System.Drawing.Point(1391, 48);
            this.labelBloqueado.Name = "labelBloqueado";
            this.labelBloqueado.Size = new System.Drawing.Size(240, 96);
            this.labelBloqueado.TabIndex = 13;
            this.labelBloqueado.Text = "Bloqueado";
            this.labelBloqueado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRevisado
            // 
            this.labelRevisado.AutoSize = true;
            this.labelRevisado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelRevisado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRevisado.Location = new System.Drawing.Point(1146, 48);
            this.labelRevisado.Name = "labelRevisado";
            this.labelRevisado.Size = new System.Drawing.Size(239, 96);
            this.labelRevisado.TabIndex = 12;
            this.labelRevisado.Text = "Revisado";
            this.labelRevisado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEntregado
            // 
            this.labelEntregado.AutoSize = true;
            this.labelEntregado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelEntregado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEntregado.Location = new System.Drawing.Point(901, 48);
            this.labelEntregado.Name = "labelEntregado";
            this.labelEntregado.Size = new System.Drawing.Size(239, 96);
            this.labelEntregado.TabIndex = 11;
            this.labelEntregado.Text = "Entregado";
            this.labelEntregado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEnProgreso
            // 
            this.labelEnProgreso.AutoSize = true;
            this.labelEnProgreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelEnProgreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEnProgreso.Location = new System.Drawing.Point(656, 48);
            this.labelEnProgreso.Name = "labelEnProgreso";
            this.labelEnProgreso.Size = new System.Drawing.Size(239, 96);
            this.labelEnProgreso.TabIndex = 10;
            this.labelEnProgreso.Text = "En Progreso";
            this.labelEnProgreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTarea
            // 
            this.labelTarea.BackColor = System.Drawing.Color.White;
            this.labelTarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTarea.Location = new System.Drawing.Point(3, 48);
            this.labelTarea.Name = "labelTarea";
            this.labelTarea.Size = new System.Drawing.Size(304, 96);
            this.labelTarea.TabIndex = 6;
            this.labelTarea.Text = "TAREA";
            this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewTareas
            // 
            this.dataGridViewTareas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTareas.ColumnHeadersVisible = false;
            this.grid.SetColumnSpan(this.dataGridViewTareas, 2);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTareas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTareas.GridColor = System.Drawing.Color.White;
            this.dataGridViewTareas.Location = new System.Drawing.Point(3, 147);
            this.dataGridViewTareas.Name = "dataGridViewTareas";
            this.dataGridViewTareas.RowHeadersVisible = false;
            this.dataGridViewTareas.RowHeadersWidth = 82;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTareas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTareas.RowTemplate.Height = 33;
            this.dataGridViewTareas.Size = new System.Drawing.Size(402, 819);
            this.dataGridViewTareas.TabIndex = 8;
            // 
            // labelPorComenzar
            // 
            this.labelPorComenzar.AutoSize = true;
            this.labelPorComenzar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelPorComenzar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPorComenzar.Location = new System.Drawing.Point(411, 48);
            this.labelPorComenzar.Name = "labelPorComenzar";
            this.labelPorComenzar.Size = new System.Drawing.Size(239, 96);
            this.labelPorComenzar.TabIndex = 9;
            this.labelPorComenzar.Text = "Por Comenzar";
            this.labelPorComenzar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelPorComenzar
            // 
            this.flowLayoutPanelPorComenzar.AllowDrop = true;
            this.flowLayoutPanelPorComenzar.AutoScroll = true;
            this.flowLayoutPanelPorComenzar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanelPorComenzar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelPorComenzar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelPorComenzar.Location = new System.Drawing.Point(411, 147);
            this.flowLayoutPanelPorComenzar.Name = "flowLayoutPanelPorComenzar";
            this.flowLayoutPanelPorComenzar.Size = new System.Drawing.Size(239, 819);
            this.flowLayoutPanelPorComenzar.TabIndex = 14;
            this.flowLayoutPanelPorComenzar.WrapContents = false;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.proyectosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.toolStripMenuItem9,
            this.salirToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(42, 42);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inicioToolStripMenuItem.Image")));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(376, 44);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // proyectosToolStripMenuItem
            // 
            this.proyectosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearNuevoProyectoToolStripMenuItem});
            this.proyectosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("proyectosToolStripMenuItem.Image")));
            this.proyectosToolStripMenuItem.Name = "proyectosToolStripMenuItem";
            this.proyectosToolStripMenuItem.Size = new System.Drawing.Size(376, 44);
            this.proyectosToolStripMenuItem.Text = "Proyectos";
            this.proyectosToolStripMenuItem.Click += new System.EventHandler(this.proyectosToolStripMenuItem_Click);
            // 
            // crearNuevoProyectoToolStripMenuItem
            // 
            this.crearNuevoProyectoToolStripMenuItem.Name = "crearNuevoProyectoToolStripMenuItem";
            this.crearNuevoProyectoToolStripMenuItem.Size = new System.Drawing.Size(378, 44);
            this.crearNuevoProyectoToolStripMenuItem.Text = "Crear nuevo proyecto";
            this.crearNuevoProyectoToolStripMenuItem.Click += new System.EventHandler(this.crearNuevoProyectoToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearNuevoUsuarioToolStripMenuItem});
            this.usuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem.Image")));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(376, 44);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // crearNuevoUsuarioToolStripMenuItem
            // 
            this.crearNuevoUsuarioToolStripMenuItem.Name = "crearNuevoUsuarioToolStripMenuItem";
            this.crearNuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(362, 44);
            this.crearNuevoUsuarioToolStripMenuItem.Text = "Crear nuevo usuario";
            this.crearNuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.crearNuevoUsuarioToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rolesToolStripMenuItem.Image")));
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(376, 44);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem9.Image")));
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItem9.Size = new System.Drawing.Size(376, 44);
            this.toolStripMenuItem9.Text = "Guardar datos";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.guardarDatosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(376, 44);
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
            this.btnUsuario.Size = new System.Drawing.Size(46, 42);
            this.btnUsuario.Text = "Usuario";
            // 
            // btnTaskiller
            // 
            this.btnTaskiller.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTaskiller.Image = ((System.Drawing.Image)(resources.GetObject("btnTaskiller.Image")));
            this.btnTaskiller.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTaskiller.Name = "btnTaskiller";
            this.btnTaskiller.Size = new System.Drawing.Size(46, 42);
            this.btnTaskiller.Text = "TaskillerLogo";
            // 
            // buttonAnadirTarea
            // 
            this.buttonAnadirTarea.BackgroundImage = global::TASKILLER.Properties.Resources.agregar;
            this.buttonAnadirTarea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAnadirTarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAnadirTarea.FlatAppearance.BorderSize = 0;
            this.buttonAnadirTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnadirTarea.Location = new System.Drawing.Point(313, 51);
            this.buttonAnadirTarea.Name = "buttonAnadirTarea";
            this.buttonAnadirTarea.Size = new System.Drawing.Size(92, 90);
            this.buttonAnadirTarea.TabIndex = 7;
            this.buttonAnadirTarea.UseVisualStyleBackColor = true;
            this.buttonAnadirTarea.Click += new System.EventHandler(this.buttonAnadirTarea_Click);
            // 
            // FormListaTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1634, 969);
            this.Controls.Add(this.grid);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListaTareas";
            this.Text = "Tareas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormListaTareas_Load);
            this.grid.ResumeLayout(false);
            this.grid.PerformLayout();
            this.toolStripInicio.ResumeLayout(false);
            this.toolStripInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTareas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel grid;
        private System.Windows.Forms.Label labelTarea;
        private System.Windows.Forms.DataGridView dataGridViewTareas;
        private System.Windows.Forms.Label labelPorComenzar;
        private System.Windows.Forms.Label labelBloqueado;
        private System.Windows.Forms.Label labelRevisado;
        private System.Windows.Forms.Label labelEntregado;
        private System.Windows.Forms.Label labelEnProgreso;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBloqueado;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRevisado;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEntregado;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEnProgreso;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPorComenzar;
        private System.Windows.Forms.ToolStrip toolStripInicio;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNuevoProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnUsuario;
        private System.Windows.Forms.ToolStripButton btnTaskiller;
        private System.Windows.Forms.Button buttonAnadirTarea;
    }
}