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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaTareas));
            this.grid = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripInicio = new System.Windows.Forms.ToolStrip();
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutPanelBloqueado = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelRevisado = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelEntregado = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelEnProgreso = new System.Windows.Forms.FlowLayoutPanel();
            this.labelBloqueado = new System.Windows.Forms.Label();
            this.labelRevisado = new System.Windows.Forms.Label();
            this.labelEntregado = new System.Windows.Forms.Label();
            this.labelEnProgreso = new System.Windows.Forms.Label();
            this.labelTarea = new System.Windows.Forms.Label();
            this.buttonAnadirTarea = new System.Windows.Forms.Button();
            this.dataGridViewTareas = new System.Windows.Forms.DataGridView();
            this.labelPorComenzar = new System.Windows.Forms.Label();
            this.flowLayoutPanelPorComenzar = new System.Windows.Forms.FlowLayoutPanel();
            this.grid.SuspendLayout();
            this.toolStripInicio.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.ColumnCount = 7;
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.grid.Controls.Add(this.toolStripInicio, 0, 0);
            this.grid.Controls.Add(this.toolStrip1, 0, 3);
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
            this.grid.Margin = new System.Windows.Forms.Padding(2);
            this.grid.Name = "grid";
            this.grid.RowCount = 4;
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.997679F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.799371F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.20295F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.grid.Size = new System.Drawing.Size(1089, 620);
            this.grid.TabIndex = 0;
            // 
            // toolStripInicio
            // 
            this.grid.SetColumnSpan(this.toolStripInicio, 7);
            this.toolStripInicio.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripInicio.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.btnUsuario,
            this.btnTaskiller});
            this.toolStripInicio.Location = new System.Drawing.Point(0, 0);
            this.toolStripInicio.Name = "toolStripInicio";
            this.toolStripInicio.Size = new System.Drawing.Size(1089, 27);
            this.toolStripInicio.TabIndex = 20;
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
            this.toolStripMenuItem9,
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
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem9.Image")));
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItem9.Size = new System.Drawing.Size(236, 26);
            this.toolStripMenuItem9.Text = "Guardar datos";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.guardarDatosToolStripMenuItem_Click);
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
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 598);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(272, 22);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem5,
            this.toolStripMenuItem7,
            this.guardarDatosToolStripMenuItem,
            this.toolStripMenuItem8});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(34, 19);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(236, 26);
            this.toolStripMenuItem1.Text = "Inicio";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(236, 26);
            this.toolStripMenuItem2.Text = "Proyectos";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(279, 26);
            this.toolStripMenuItem3.Text = "Crear nuevo proyecto";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(279, 26);
            this.toolStripMenuItem4.Text = "Modificar/Eliminar proyecto";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6});
            this.toolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.Image")));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(236, 26);
            this.toolStripMenuItem5.Text = "Usuarios";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(223, 26);
            this.toolStripMenuItem6.Text = "Crear nuevo usuario";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem7.Image")));
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(236, 26);
            this.toolStripMenuItem7.Text = "Roles";
            // 
            // guardarDatosToolStripMenuItem
            // 
            this.guardarDatosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarDatosToolStripMenuItem.Image")));
            this.guardarDatosToolStripMenuItem.Name = "guardarDatosToolStripMenuItem";
            this.guardarDatosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarDatosToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.guardarDatosToolStripMenuItem.Text = "Guardar datos";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem8.Image")));
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.toolStripMenuItem8.Size = new System.Drawing.Size(236, 26);
            this.toolStripMenuItem8.Text = "Salir";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 19);
            this.toolStripButton1.Text = "Usuario";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 19);
            this.toolStripButton2.Text = "TaskillerLogo";
            // 
            // flowLayoutPanelBloqueado
            // 
            this.flowLayoutPanelBloqueado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBloqueado.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelBloqueado.Location = new System.Drawing.Point(936, 89);
            this.flowLayoutPanelBloqueado.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelBloqueado.Name = "flowLayoutPanelBloqueado";
            this.flowLayoutPanelBloqueado.Size = new System.Drawing.Size(151, 507);
            this.flowLayoutPanelBloqueado.TabIndex = 18;
            // 
            // flowLayoutPanelRevisado
            // 
            this.flowLayoutPanelRevisado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelRevisado.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelRevisado.Location = new System.Drawing.Point(784, 89);
            this.flowLayoutPanelRevisado.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelRevisado.Name = "flowLayoutPanelRevisado";
            this.flowLayoutPanelRevisado.Size = new System.Drawing.Size(148, 507);
            this.flowLayoutPanelRevisado.TabIndex = 17;
            // 
            // flowLayoutPanelEntregado
            // 
            this.flowLayoutPanelEntregado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelEntregado.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelEntregado.Location = new System.Drawing.Point(632, 89);
            this.flowLayoutPanelEntregado.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelEntregado.Name = "flowLayoutPanelEntregado";
            this.flowLayoutPanelEntregado.Size = new System.Drawing.Size(148, 507);
            this.flowLayoutPanelEntregado.TabIndex = 16;
            // 
            // flowLayoutPanelEnProgreso
            // 
            this.flowLayoutPanelEnProgreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelEnProgreso.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelEnProgreso.Location = new System.Drawing.Point(480, 89);
            this.flowLayoutPanelEnProgreso.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelEnProgreso.Name = "flowLayoutPanelEnProgreso";
            this.flowLayoutPanelEnProgreso.Size = new System.Drawing.Size(148, 507);
            this.flowLayoutPanelEnProgreso.TabIndex = 15;
            // 
            // labelBloqueado
            // 
            this.labelBloqueado.AutoSize = true;
            this.labelBloqueado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBloqueado.Location = new System.Drawing.Point(936, 29);
            this.labelBloqueado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBloqueado.Name = "labelBloqueado";
            this.labelBloqueado.Size = new System.Drawing.Size(151, 58);
            this.labelBloqueado.TabIndex = 13;
            this.labelBloqueado.Text = "Bloqueado";
            this.labelBloqueado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRevisado
            // 
            this.labelRevisado.AutoSize = true;
            this.labelRevisado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRevisado.Location = new System.Drawing.Point(784, 29);
            this.labelRevisado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRevisado.Name = "labelRevisado";
            this.labelRevisado.Size = new System.Drawing.Size(148, 58);
            this.labelRevisado.TabIndex = 12;
            this.labelRevisado.Text = "Revisado";
            this.labelRevisado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEntregado
            // 
            this.labelEntregado.AutoSize = true;
            this.labelEntregado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEntregado.Location = new System.Drawing.Point(632, 29);
            this.labelEntregado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEntregado.Name = "labelEntregado";
            this.labelEntregado.Size = new System.Drawing.Size(148, 58);
            this.labelEntregado.TabIndex = 11;
            this.labelEntregado.Text = "Entregado";
            this.labelEntregado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEnProgreso
            // 
            this.labelEnProgreso.AutoSize = true;
            this.labelEnProgreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEnProgreso.Location = new System.Drawing.Point(480, 29);
            this.labelEnProgreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEnProgreso.Name = "labelEnProgreso";
            this.labelEnProgreso.Size = new System.Drawing.Size(148, 58);
            this.labelEnProgreso.TabIndex = 10;
            this.labelEnProgreso.Text = "En Progreso";
            this.labelEnProgreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTarea
            // 
            this.labelTarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTarea.Location = new System.Drawing.Point(2, 29);
            this.labelTarea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTarea.Name = "labelTarea";
            this.labelTarea.Size = new System.Drawing.Size(268, 58);
            this.labelTarea.TabIndex = 6;
            this.labelTarea.Text = "TAREA";
            this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAnadirTarea
            // 
            this.buttonAnadirTarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAnadirTarea.Location = new System.Drawing.Point(274, 31);
            this.buttonAnadirTarea.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAnadirTarea.Name = "buttonAnadirTarea";
            this.buttonAnadirTarea.Size = new System.Drawing.Size(50, 54);
            this.buttonAnadirTarea.TabIndex = 7;
            this.buttonAnadirTarea.Text = "+";
            this.buttonAnadirTarea.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTareas
            // 
            this.dataGridViewTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.SetColumnSpan(this.dataGridViewTareas, 2);
            this.dataGridViewTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTareas.Location = new System.Drawing.Point(2, 89);
            this.dataGridViewTareas.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTareas.Name = "dataGridViewTareas";
            this.dataGridViewTareas.RowHeadersWidth = 82;
            this.dataGridViewTareas.RowTemplate.Height = 33;
            this.dataGridViewTareas.Size = new System.Drawing.Size(322, 507);
            this.dataGridViewTareas.TabIndex = 8;
            // 
            // labelPorComenzar
            // 
            this.labelPorComenzar.AutoSize = true;
            this.labelPorComenzar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPorComenzar.Location = new System.Drawing.Point(328, 29);
            this.labelPorComenzar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPorComenzar.Name = "labelPorComenzar";
            this.labelPorComenzar.Size = new System.Drawing.Size(148, 58);
            this.labelPorComenzar.TabIndex = 9;
            this.labelPorComenzar.Text = "Por Comenzar";
            this.labelPorComenzar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelPorComenzar
            // 
            this.flowLayoutPanelPorComenzar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelPorComenzar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelPorComenzar.Location = new System.Drawing.Point(328, 89);
            this.flowLayoutPanelPorComenzar.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelPorComenzar.Name = "flowLayoutPanelPorComenzar";
            this.flowLayoutPanelPorComenzar.Size = new System.Drawing.Size(148, 507);
            this.flowLayoutPanelPorComenzar.TabIndex = 14;
            // 
            // FormListaTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1089, 620);
            this.Controls.Add(this.grid);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormListaTareas";
            this.Text = "Tareas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grid.ResumeLayout(false);
            this.grid.PerformLayout();
            this.toolStripInicio.ResumeLayout(false);
            this.toolStripInicio.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTareas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel grid;
        private System.Windows.Forms.Label labelTarea;
        private System.Windows.Forms.Button buttonAnadirTarea;
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem guardarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}