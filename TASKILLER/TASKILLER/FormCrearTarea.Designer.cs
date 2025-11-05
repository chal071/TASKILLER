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
            this.flowLayoutPanelTop = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelCuentanos = new System.Windows.Forms.Label();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.dateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.labelFechaFinal = new System.Windows.Forms.Label();
            this.dateTimePickerFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.labelEstado = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.labelUsuarioAsignado = new System.Windows.Forms.Label();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.tableLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.labelPrioridad = new System.Windows.Forms.Label();
            this.richTextBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.comboBoxPrioridad = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelRight = new System.Windows.Forms.TableLayoutPanel();
            this.checkedListBoxUsuario = new System.Windows.Forms.CheckedListBox();
            this.grid.SuspendLayout();
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
            this.grid.Controls.Add(this.flowLayoutPanelTop, 0, 0);
            this.grid.Controls.Add(this.buttonCrear, 1, 2);
            this.grid.Controls.Add(this.tableLayoutPanelLeft, 0, 1);
            this.grid.Controls.Add(this.tableLayoutPanelRight, 1, 1);
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Margin = new System.Windows.Forms.Padding(0);
            this.grid.Name = "grid";
            this.grid.RowCount = 3;
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.grid.Size = new System.Drawing.Size(1634, 969);
            this.grid.TabIndex = 0;
            // 
            // flowLayoutPanelTop
            // 
            this.grid.SetColumnSpan(this.flowLayoutPanelTop, 2);
            this.flowLayoutPanelTop.Controls.Add(this.pictureBoxLogo);
            this.flowLayoutPanelTop.Controls.Add(this.labelCuentanos);
            this.flowLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTop.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            this.flowLayoutPanelTop.Size = new System.Drawing.Size(1628, 187);
            this.flowLayoutPanelTop.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxLogo.Image = global::TASKILLER.Properties.Resources.LOGO;
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(312, 233);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelCuentanos
            // 
            this.labelCuentanos.AutoSize = true;
            this.labelCuentanos.Location = new System.Drawing.Point(321, 0);
            this.labelCuentanos.Name = "labelCuentanos";
            this.labelCuentanos.Size = new System.Drawing.Size(191, 50);
            this.labelCuentanos.TabIndex = 1;
            this.labelCuentanos.Text = "Cuéntanos sobre \r\nesta nueva tarea...";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFechaInicio.Location = new System.Drawing.Point(3, 0);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(805, 62);
            this.labelFechaInicio.TabIndex = 0;
            this.labelFechaInicio.Text = "FECHA INICIO";
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(3, 65);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(805, 31);
            this.dateTimePickerFechaInicio.TabIndex = 1;
            // 
            // labelFechaFinal
            // 
            this.labelFechaFinal.AutoSize = true;
            this.labelFechaFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFechaFinal.Location = new System.Drawing.Point(3, 124);
            this.labelFechaFinal.Name = "labelFechaFinal";
            this.labelFechaFinal.Size = new System.Drawing.Size(805, 62);
            this.labelFechaFinal.TabIndex = 2;
            this.labelFechaFinal.Text = "FECHA FINAL";
            // 
            // dateTimePickerFechaFinal
            // 
            this.dateTimePickerFechaFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerFechaFinal.Location = new System.Drawing.Point(3, 189);
            this.dateTimePickerFechaFinal.Name = "dateTimePickerFechaFinal";
            this.dateTimePickerFechaFinal.Size = new System.Drawing.Size(805, 31);
            this.dateTimePickerFechaFinal.TabIndex = 3;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEstado.Location = new System.Drawing.Point(3, 248);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(805, 62);
            this.labelEstado.TabIndex = 5;
            this.labelEstado.Text = "ESTADO";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(3, 313);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(805, 33);
            this.comboBoxEstado.TabIndex = 4;
            // 
            // labelUsuarioAsignado
            // 
            this.labelUsuarioAsignado.AutoSize = true;
            this.labelUsuarioAsignado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUsuarioAsignado.Location = new System.Drawing.Point(3, 372);
            this.labelUsuarioAsignado.Name = "labelUsuarioAsignado";
            this.labelUsuarioAsignado.Size = new System.Drawing.Size(805, 62);
            this.labelUsuarioAsignado.TabIndex = 6;
            this.labelUsuarioAsignado.Text = "USUARIO ASIGNADO";
            // 
            // buttonCrear
            // 
            this.buttonCrear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCrear.Location = new System.Drawing.Point(1378, 848);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(253, 94);
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
            this.tableLayoutPanelLeft.Location = new System.Drawing.Point(3, 196);
            this.tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
            this.tableLayoutPanelLeft.RowCount = 6;
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelLeft.Size = new System.Drawing.Size(811, 623);
            this.tableLayoutPanelLeft.TabIndex = 4;
            // 
            // labelPrioridad
            // 
            this.labelPrioridad.AutoSize = true;
            this.labelPrioridad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPrioridad.Location = new System.Drawing.Point(3, 446);
            this.labelPrioridad.Name = "labelPrioridad";
            this.labelPrioridad.Size = new System.Drawing.Size(805, 49);
            this.labelPrioridad.TabIndex = 4;
            this.labelPrioridad.Text = "PRIORIDAD";
            // 
            // richTextBoxDescripcion
            // 
            this.richTextBoxDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDescripcion.Location = new System.Drawing.Point(3, 163);
            this.richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            this.richTextBoxDescripcion.Size = new System.Drawing.Size(805, 280);
            this.richTextBoxDescripcion.TabIndex = 3;
            this.richTextBoxDescripcion.Text = "";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitulo.Location = new System.Drawing.Point(3, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(805, 49);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "TÍTULO";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(3, 111);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(155, 25);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "DESCRIPCIÓN";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTitulo.Location = new System.Drawing.Point(3, 52);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(805, 31);
            this.textBoxTitulo.TabIndex = 1;
            // 
            // comboBoxPrioridad
            // 
            this.comboBoxPrioridad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxPrioridad.FormattingEnabled = true;
            this.comboBoxPrioridad.Location = new System.Drawing.Point(3, 498);
            this.comboBoxPrioridad.Name = "comboBoxPrioridad";
            this.comboBoxPrioridad.Size = new System.Drawing.Size(805, 33);
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
            this.tableLayoutPanelRight.Location = new System.Drawing.Point(820, 196);
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
            this.tableLayoutPanelRight.Size = new System.Drawing.Size(811, 623);
            this.tableLayoutPanelRight.TabIndex = 5;
            // 
            // checkedListBoxUsuario
            // 
            this.checkedListBoxUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxUsuario.FormattingEnabled = true;
            this.checkedListBoxUsuario.Location = new System.Drawing.Point(3, 437);
            this.checkedListBoxUsuario.Name = "checkedListBoxUsuario";
            this.checkedListBoxUsuario.Size = new System.Drawing.Size(805, 183);
            this.checkedListBoxUsuario.TabIndex = 7;
            // 
            // FormCrearTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1634, 969);
            this.Controls.Add(this.grid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCrearTarea";
            this.Text = "Crear nueva tarea";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grid.ResumeLayout(false);
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
    }
}