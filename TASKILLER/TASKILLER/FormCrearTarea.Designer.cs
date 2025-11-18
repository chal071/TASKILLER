namespace TASKILLER
{
    partial class FormCrearTarea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearTarea));
            this.grid = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripInicio = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNuevoProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEliminarProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsuario = new System.Windows.Forms.ToolStripButton();
            this.btnTaskiller = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutPanelTop = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelCuentanos = new System.Windows.Forms.Label();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.tableLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.labelPrioridad = new System.Windows.Forms.Label();
            this.richTextBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.comboBoxPrioridad = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelRight = new System.Windows.Forms.TableLayoutPanel();
            this.labelUsuarioAsignado = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.dateTimePickerFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.labelFechaFinal = new System.Windows.Forms.Label();
            this.dateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.checkedListBoxUsuario = new System.Windows.Forms.CheckedListBox();
            this.grid.SuspendLayout();
            this.toolStripInicio.SuspendLayout();
            this.flowLayoutPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tableLayoutPanelLeft.SuspendLayout();
            this.tableLayoutPanelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.ColumnCount = 2;
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.grid.Controls.Add(this.toolStripInicio, 0, 0);
            this.grid.Controls.Add(this.flowLayoutPanelTop, 0, 1);
            this.grid.Controls.Add(this.buttonCrear, 1, 3);
            this.grid.Controls.Add(this.tableLayoutPanelLeft, 0, 2);
            this.grid.Controls.Add(this.tableLayoutPanelRight, 1, 2);
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Margin = new System.Windows.Forms.Padding(0);
            this.grid.Name = "grid";
            this.grid.RowCount = 4;
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.grid.Size = new System.Drawing.Size(1089, 620);
            this.grid.TabIndex = 0;
            // 
            // toolStripInicio
            // 
            this.grid.SetColumnSpan(this.toolStripInicio, 2);
            this.toolStripInicio.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripInicio.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.btnUsuario,
            this.btnTaskiller});
            this.toolStripInicio.Location = new System.Drawing.Point(0, 0);
            this.toolStripInicio.Name = "toolStripInicio";
            this.toolStripInicio.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripInicio.Size = new System.Drawing.Size(1089, 27);
            this.toolStripInicio.TabIndex = 6;
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
            this.salirToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // proyectosToolStripMenuItem
            // 
            this.proyectosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearNuevoProyectoToolStripMenuItem,
            this.modificarEliminarProyectoToolStripMenuItem});
            this.proyectosToolStripMenuItem.Name = "proyectosToolStripMenuItem";
            this.proyectosToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.proyectosToolStripMenuItem.Text = "Proyectos";
            // 
            // crearNuevoProyectoToolStripMenuItem
            // 
            this.crearNuevoProyectoToolStripMenuItem.Name = "crearNuevoProyectoToolStripMenuItem";
            this.crearNuevoProyectoToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.crearNuevoProyectoToolStripMenuItem.Text = "Crear nuevo proyecto";
            // 
            // modificarEliminarProyectoToolStripMenuItem
            // 
            this.modificarEliminarProyectoToolStripMenuItem.Name = "modificarEliminarProyectoToolStripMenuItem";
            this.modificarEliminarProyectoToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.modificarEliminarProyectoToolStripMenuItem.Text = "Modificar/Eliminar proyecto";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearNuevoUsuarioToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // crearNuevoUsuarioToolStripMenuItem
            // 
            this.crearNuevoUsuarioToolStripMenuItem.Name = "crearNuevoUsuarioToolStripMenuItem";
            this.crearNuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.crearNuevoUsuarioToolStripMenuItem.Text = "Crear nuevo usuario";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.rolesToolStripMenuItem.Text = "Roles";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.salirToolStripMenuItem.Text = "Salir";
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
            // flowLayoutPanelTop
            // 
            this.grid.SetColumnSpan(this.flowLayoutPanelTop, 2);
            this.flowLayoutPanelTop.Controls.Add(this.pictureBoxLogo);
            this.flowLayoutPanelTop.Controls.Add(this.labelCuentanos);
            this.flowLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTop.Location = new System.Drawing.Point(2, 33);
            this.flowLayoutPanelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            this.flowLayoutPanelTop.Size = new System.Drawing.Size(1085, 120);
            this.flowLayoutPanelTop.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxLogo.Image = global::TASKILLER.Properties.Resources.LOGO;
            this.pictureBoxLogo.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(208, 149);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelCuentanos
            // 
            this.labelCuentanos.AutoSize = true;
            this.labelCuentanos.Location = new System.Drawing.Point(214, 0);
            this.labelCuentanos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCuentanos.Name = "labelCuentanos";
            this.labelCuentanos.Size = new System.Drawing.Size(116, 32);
            this.labelCuentanos.TabIndex = 1;
            this.labelCuentanos.Text = "Cuéntanos sobre \r\nesta nueva tarea...";
            // 
            // buttonCrear
            // 
            this.buttonCrear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCrear.Location = new System.Drawing.Point(918, 543);
            this.buttonCrear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(169, 60);
            this.buttonCrear.TabIndex = 3;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelLeft
            // 
            this.tableLayoutPanelLeft.ColumnCount = 1;
            this.tableLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLeft.Controls.Add(this.labelPrioridad, 0, 4);
            this.tableLayoutPanelLeft.Controls.Add(this.richTextBoxDescripcion, 0, 3);
            this.tableLayoutPanelLeft.Controls.Add(this.labelTitulo, 0, 0);
            this.tableLayoutPanelLeft.Controls.Add(this.labelDescripcion, 0, 2);
            this.tableLayoutPanelLeft.Controls.Add(this.textBoxTitulo, 0, 1);
            this.tableLayoutPanelLeft.Controls.Add(this.comboBoxPrioridad, 0, 5);
            this.tableLayoutPanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLeft.Location = new System.Drawing.Point(2, 157);
            this.tableLayoutPanelLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
            this.tableLayoutPanelLeft.RowCount = 6;
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelLeft.Size = new System.Drawing.Size(540, 368);
            this.tableLayoutPanelLeft.TabIndex = 4;
            // 
            // labelPrioridad
            // 
            this.labelPrioridad.AutoSize = true;
            this.labelPrioridad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPrioridad.Location = new System.Drawing.Point(2, 263);
            this.labelPrioridad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrioridad.Name = "labelPrioridad";
            this.labelPrioridad.Size = new System.Drawing.Size(536, 29);
            this.labelPrioridad.TabIndex = 4;
            this.labelPrioridad.Text = "PRIORIDAD";
            // 
            // richTextBoxDescripcion
            // 
            this.richTextBoxDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDescripcion.Location = new System.Drawing.Point(2, 96);
            this.richTextBoxDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            this.richTextBoxDescripcion.Size = new System.Drawing.Size(536, 165);
            this.richTextBoxDescripcion.TabIndex = 3;
            this.richTextBoxDescripcion.Text = "";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitulo.Location = new System.Drawing.Point(2, 0);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(536, 29);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "TÍTULO";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(2, 65);
            this.labelDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(98, 16);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "DESCRIPCIÓN";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTitulo.Location = new System.Drawing.Point(2, 31);
            this.textBoxTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(536, 22);
            this.textBoxTitulo.TabIndex = 1;
            // 
            // comboBoxPrioridad
            // 
            this.comboBoxPrioridad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxPrioridad.FormattingEnabled = true;
            this.comboBoxPrioridad.Location = new System.Drawing.Point(2, 294);
            this.comboBoxPrioridad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxPrioridad.Name = "comboBoxPrioridad";
            this.comboBoxPrioridad.Size = new System.Drawing.Size(536, 24);
            this.comboBoxPrioridad.TabIndex = 5;
            // 
            // tableLayoutPanelRight
            // 
            this.tableLayoutPanelRight.ColumnCount = 1;
            this.tableLayoutPanelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRight.Controls.Add(this.labelUsuarioAsignado, 0, 6);
            this.tableLayoutPanelRight.Controls.Add(this.comboBoxEstado, 0, 5);
            this.tableLayoutPanelRight.Controls.Add(this.labelEstado, 0, 4);
            this.tableLayoutPanelRight.Controls.Add(this.dateTimePickerFechaFinal, 0, 3);
            this.tableLayoutPanelRight.Controls.Add(this.labelFechaFinal, 0, 2);
            this.tableLayoutPanelRight.Controls.Add(this.dateTimePickerFechaInicio, 0, 1);
            this.tableLayoutPanelRight.Controls.Add(this.labelFechaInicio, 0, 0);
            this.tableLayoutPanelRight.Controls.Add(this.checkedListBoxUsuario, 0, 7);
            this.tableLayoutPanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRight.Location = new System.Drawing.Point(546, 157);
            this.tableLayoutPanelRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanelRight.Name = "tableLayoutPanelRight";
            this.tableLayoutPanelRight.RowCount = 8;
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelRight.Size = new System.Drawing.Size(541, 368);
            this.tableLayoutPanelRight.TabIndex = 5;
            // 
            // labelUsuarioAsignado
            // 
            this.labelUsuarioAsignado.AutoSize = true;
            this.labelUsuarioAsignado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUsuarioAsignado.Location = new System.Drawing.Point(2, 216);
            this.labelUsuarioAsignado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsuarioAsignado.Name = "labelUsuarioAsignado";
            this.labelUsuarioAsignado.Size = new System.Drawing.Size(537, 36);
            this.labelUsuarioAsignado.TabIndex = 6;
            this.labelUsuarioAsignado.Text = "USUARIO ASIGNADO";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(2, 182);
            this.comboBoxEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(537, 24);
            this.comboBoxEstado.TabIndex = 4;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEstado.Location = new System.Drawing.Point(2, 144);
            this.labelEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(537, 36);
            this.labelEstado.TabIndex = 5;
            this.labelEstado.Text = "ESTADO";
            // 
            // dateTimePickerFechaFinal
            // 
            this.dateTimePickerFechaFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerFechaFinal.Location = new System.Drawing.Point(2, 110);
            this.dateTimePickerFechaFinal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerFechaFinal.Name = "dateTimePickerFechaFinal";
            this.dateTimePickerFechaFinal.Size = new System.Drawing.Size(537, 22);
            this.dateTimePickerFechaFinal.TabIndex = 3;
            // 
            // labelFechaFinal
            // 
            this.labelFechaFinal.AutoSize = true;
            this.labelFechaFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFechaFinal.Location = new System.Drawing.Point(2, 72);
            this.labelFechaFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaFinal.Name = "labelFechaFinal";
            this.labelFechaFinal.Size = new System.Drawing.Size(537, 36);
            this.labelFechaFinal.TabIndex = 2;
            this.labelFechaFinal.Text = "FECHA FINAL";
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(2, 38);
            this.dateTimePickerFechaInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(537, 22);
            this.dateTimePickerFechaInicio.TabIndex = 1;
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFechaInicio.Location = new System.Drawing.Point(2, 0);
            this.labelFechaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(537, 36);
            this.labelFechaInicio.TabIndex = 0;
            this.labelFechaInicio.Text = "FECHA INICIO";
            // 
            // checkedListBoxUsuario
            // 
            this.checkedListBoxUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxUsuario.FormattingEnabled = true;
            this.checkedListBoxUsuario.Location = new System.Drawing.Point(2, 254);
            this.checkedListBoxUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListBoxUsuario.Name = "checkedListBoxUsuario";
            this.checkedListBoxUsuario.Size = new System.Drawing.Size(537, 112);
            this.checkedListBoxUsuario.TabIndex = 7;
            // 
            // FormCrearTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1089, 620);
            this.Controls.Add(this.grid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCrearTarea";
            this.Text = "Crear nueva tarea";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grid.ResumeLayout(false);
            this.grid.PerformLayout();
            this.toolStripInicio.ResumeLayout(false);
            this.toolStripInicio.PerformLayout();
            this.flowLayoutPanelTop.ResumeLayout(false);
            this.flowLayoutPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tableLayoutPanelLeft.ResumeLayout(false);
            this.tableLayoutPanelLeft.PerformLayout();
            this.tableLayoutPanelRight.ResumeLayout(false);
            this.tableLayoutPanelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel grid;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTop;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelCuentanos;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.RichTextBox richTextBoxDescripcion;
        private System.Windows.Forms.Label labelPrioridad;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicio;
        private System.Windows.Forms.Label labelFechaFinal;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFinal;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label labelUsuarioAsignado;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeft;
        private System.Windows.Forms.ComboBox comboBoxPrioridad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRight;
        private System.Windows.Forms.CheckedListBox checkedListBoxUsuario;
        private System.Windows.Forms.ToolStrip toolStripInicio;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNuevoProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEliminarProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnUsuario;
        private System.Windows.Forms.ToolStripButton btnTaskiller;
    }
}