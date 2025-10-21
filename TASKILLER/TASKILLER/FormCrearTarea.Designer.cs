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
            this.flowLayoutPanelLogo = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelCuentanosTarea = new System.Windows.Forms.Label();
            this.flowLayoutPanelTituloDescrip = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.labelPrioridad = new System.Windows.Forms.Label();
            this.comboBoxPrioridad = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelFechaEstado = new System.Windows.Forms.FlowLayoutPanel();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.dateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.labelFinal = new System.Windows.Forms.Label();
            this.dateTimePickerFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.labelEstado = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.labelUsuariosAsignado = new System.Windows.Forms.Label();
            this.checkedListBoxUsuarioAsignado = new System.Windows.Forms.CheckedListBox();
            this.flowLayoutPanelButtonCrear = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCrearTarea = new System.Windows.Forms.Button();
            this.flowLayoutPanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.flowLayoutPanelTituloDescrip.SuspendLayout();
            this.flowLayoutPanelFechaEstado.SuspendLayout();
            this.flowLayoutPanelButtonCrear.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelLogo
            // 
            this.flowLayoutPanelLogo.AutoSize = true;
            this.flowLayoutPanelLogo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelLogo.Controls.Add(this.pictureBoxLogo);
            this.flowLayoutPanelLogo.Controls.Add(this.labelCuentanosTarea);
            this.flowLayoutPanelLogo.Location = new System.Drawing.Point(-1, 3);
            this.flowLayoutPanelLogo.Name = "flowLayoutPanelLogo";
            this.flowLayoutPanelLogo.Size = new System.Drawing.Size(531, 218);
            this.flowLayoutPanelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::TASKILLER.Properties.Resources.LOGO;
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(326, 212);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelCuentanosTarea
            // 
            this.labelCuentanosTarea.AutoSize = true;
            this.labelCuentanosTarea.Location = new System.Drawing.Point(336, 0);
            this.labelCuentanosTarea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCuentanosTarea.MaximumSize = new System.Drawing.Size(900, 0);
            this.labelCuentanosTarea.Name = "labelCuentanosTarea";
            this.labelCuentanosTarea.Size = new System.Drawing.Size(191, 50);
            this.labelCuentanosTarea.TabIndex = 2;
            this.labelCuentanosTarea.Text = "Cuéntanos sobre \r\nesta nueva tarea...";
            this.labelCuentanosTarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanelTituloDescrip
            // 
            this.flowLayoutPanelTituloDescrip.AutoSize = true;
            this.flowLayoutPanelTituloDescrip.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelTituloDescrip.Controls.Add(this.labelTitulo);
            this.flowLayoutPanelTituloDescrip.Controls.Add(this.textBoxTitulo);
            this.flowLayoutPanelTituloDescrip.Controls.Add(this.labelDescripcion);
            this.flowLayoutPanelTituloDescrip.Controls.Add(this.textBoxDescripcion);
            this.flowLayoutPanelTituloDescrip.Controls.Add(this.labelPrioridad);
            this.flowLayoutPanelTituloDescrip.Controls.Add(this.comboBoxPrioridad);
            this.flowLayoutPanelTituloDescrip.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelTituloDescrip.Location = new System.Drawing.Point(2, 224);
            this.flowLayoutPanelTituloDescrip.Name = "flowLayoutPanelTituloDescrip";
            this.flowLayoutPanelTituloDescrip.Size = new System.Drawing.Size(581, 440);
            this.flowLayoutPanelTituloDescrip.TabIndex = 1;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(3, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(92, 25);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "TÍTULO:";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(3, 28);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(323, 31);
            this.textBoxTitulo.TabIndex = 0;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(3, 62);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(161, 25);
            this.labelDescripcion.TabIndex = 3;
            this.labelDescripcion.Text = "DESCRIPCIÓN:";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(3, 90);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(575, 283);
            this.textBoxDescripcion.TabIndex = 1;
            // 
            // labelPrioridad
            // 
            this.labelPrioridad.AutoSize = true;
            this.labelPrioridad.Location = new System.Drawing.Point(3, 376);
            this.labelPrioridad.Name = "labelPrioridad";
            this.labelPrioridad.Size = new System.Drawing.Size(104, 25);
            this.labelPrioridad.TabIndex = 4;
            this.labelPrioridad.Text = "Prioridad:";
            // 
            // comboBoxPrioridad
            // 
            this.comboBoxPrioridad.FormattingEnabled = true;
            this.comboBoxPrioridad.Location = new System.Drawing.Point(3, 404);
            this.comboBoxPrioridad.Name = "comboBoxPrioridad";
            this.comboBoxPrioridad.Size = new System.Drawing.Size(575, 33);
            this.comboBoxPrioridad.TabIndex = 5;
            // 
            // flowLayoutPanelFechaEstado
            // 
            this.flowLayoutPanelFechaEstado.AutoScroll = true;
            this.flowLayoutPanelFechaEstado.AutoSize = true;
            this.flowLayoutPanelFechaEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelFechaEstado.Controls.Add(this.labelFechaInicio);
            this.flowLayoutPanelFechaEstado.Controls.Add(this.dateTimePickerFechaInicio);
            this.flowLayoutPanelFechaEstado.Controls.Add(this.labelFinal);
            this.flowLayoutPanelFechaEstado.Controls.Add(this.dateTimePickerFechaFinal);
            this.flowLayoutPanelFechaEstado.Controls.Add(this.labelEstado);
            this.flowLayoutPanelFechaEstado.Controls.Add(this.comboBoxEstado);
            this.flowLayoutPanelFechaEstado.Controls.Add(this.labelUsuariosAsignado);
            this.flowLayoutPanelFechaEstado.Controls.Add(this.checkedListBoxUsuarioAsignado);
            this.flowLayoutPanelFechaEstado.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelFechaEstado.Location = new System.Drawing.Point(770, 224);
            this.flowLayoutPanelFechaEstado.Name = "flowLayoutPanelFechaEstado";
            this.flowLayoutPanelFechaEstado.Size = new System.Drawing.Size(689, 475);
            this.flowLayoutPanelFechaEstado.TabIndex = 2;
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Location = new System.Drawing.Point(3, 0);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(156, 25);
            this.labelFechaInicio.TabIndex = 0;
            this.labelFechaInicio.Text = "FECHA INICIO:";
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(3, 28);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(683, 31);
            this.dateTimePickerFechaInicio.TabIndex = 2;
            // 
            // labelFinal
            // 
            this.labelFinal.AutoSize = true;
            this.labelFinal.Location = new System.Drawing.Point(3, 62);
            this.labelFinal.Name = "labelFinal";
            this.labelFinal.Size = new System.Drawing.Size(154, 25);
            this.labelFinal.TabIndex = 1;
            this.labelFinal.Text = "FECHA FINAL:";
            // 
            // dateTimePickerFechaFinal
            // 
            this.dateTimePickerFechaFinal.Location = new System.Drawing.Point(3, 90);
            this.dateTimePickerFechaFinal.Name = "dateTimePickerFechaFinal";
            this.dateTimePickerFechaFinal.Size = new System.Drawing.Size(683, 31);
            this.dateTimePickerFechaFinal.TabIndex = 3;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(3, 124);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(104, 25);
            this.labelEstado.TabIndex = 5;
            this.labelEstado.Text = "ESTADO:";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(3, 152);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(683, 33);
            this.comboBoxEstado.TabIndex = 4;
            // 
            // labelUsuariosAsignado
            // 
            this.labelUsuariosAsignado.AutoSize = true;
            this.labelUsuariosAsignado.Location = new System.Drawing.Point(3, 188);
            this.labelUsuariosAsignado.Name = "labelUsuariosAsignado";
            this.labelUsuariosAsignado.Size = new System.Drawing.Size(227, 25);
            this.labelUsuariosAsignado.TabIndex = 7;
            this.labelUsuariosAsignado.Text = "USUARIO ASIGNADO:";
            // 
            // checkedListBoxUsuarioAsignado
            // 
            this.checkedListBoxUsuarioAsignado.FormattingEnabled = true;
            this.checkedListBoxUsuarioAsignado.Location = new System.Drawing.Point(3, 216);
            this.checkedListBoxUsuarioAsignado.Name = "checkedListBoxUsuarioAsignado";
            this.checkedListBoxUsuarioAsignado.Size = new System.Drawing.Size(683, 256);
            this.checkedListBoxUsuarioAsignado.TabIndex = 8;
            // 
            // flowLayoutPanelButtonCrear
            // 
            this.flowLayoutPanelButtonCrear.AutoSize = true;
            this.flowLayoutPanelButtonCrear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelButtonCrear.Controls.Add(this.buttonCrearTarea);
            this.flowLayoutPanelButtonCrear.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelButtonCrear.Location = new System.Drawing.Point(5, 777);
            this.flowLayoutPanelButtonCrear.Name = "flowLayoutPanelButtonCrear";
            this.flowLayoutPanelButtonCrear.Size = new System.Drawing.Size(184, 74);
            this.flowLayoutPanelButtonCrear.TabIndex = 3;
            // 
            // buttonCrearTarea
            // 
            this.buttonCrearTarea.Location = new System.Drawing.Point(3, 3);
            this.buttonCrearTarea.Name = "buttonCrearTarea";
            this.buttonCrearTarea.Size = new System.Drawing.Size(178, 68);
            this.buttonCrearTarea.TabIndex = 0;
            this.buttonCrearTarea.Text = "Crear Tarea";
            this.buttonCrearTarea.UseVisualStyleBackColor = true;
            // 
            // FormCrearTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1634, 969);
            this.Controls.Add(this.flowLayoutPanelFechaEstado);
            this.Controls.Add(this.flowLayoutPanelTituloDescrip);
            this.Controls.Add(this.flowLayoutPanelLogo);
            this.Controls.Add(this.flowLayoutPanelButtonCrear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCrearTarea";
            this.Text = "Crear nueva tarea";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanelLogo.ResumeLayout(false);
            this.flowLayoutPanelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.flowLayoutPanelTituloDescrip.ResumeLayout(false);
            this.flowLayoutPanelTituloDescrip.PerformLayout();
            this.flowLayoutPanelFechaEstado.ResumeLayout(false);
            this.flowLayoutPanelFechaEstado.PerformLayout();
            this.flowLayoutPanelButtonCrear.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelCuentanosTarea;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTituloDescrip;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFechaEstado;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicio;
        private System.Windows.Forms.Label labelFinal;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFinal;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label labelUsuariosAsignado;
        private System.Windows.Forms.CheckedListBox checkedListBoxUsuarioAsignado;
        private System.Windows.Forms.Label labelPrioridad;
        private System.Windows.Forms.ComboBox comboBoxPrioridad;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtonCrear;
        private System.Windows.Forms.Button buttonCrearTarea;
    }
}