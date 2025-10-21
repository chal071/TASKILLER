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
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
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
            this.panelInfo.Location = new System.Drawing.Point(12, 12);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1195, 823);
            this.panelInfo.TabIndex = 14;
            // 
            // buttonEditarProyecto
            // 
            this.buttonEditarProyecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditarProyecto.Location = new System.Drawing.Point(487, 743);
            this.buttonEditarProyecto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditarProyecto.Name = "buttonEditarProyecto";
            this.buttonEditarProyecto.Size = new System.Drawing.Size(328, 78);
            this.buttonEditarProyecto.TabIndex = 15;
            this.buttonEditarProyecto.Text = "Guardar proyecto";
            this.buttonEditarProyecto.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFechaFinal
            // 
            this.dateTimePickerFechaFinal.Location = new System.Drawing.Point(721, 434);
            this.dateTimePickerFechaFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFechaFinal.Name = "dateTimePickerFechaFinal";
            this.dateTimePickerFechaFinal.Size = new System.Drawing.Size(471, 22);
            this.dateTimePickerFechaFinal.TabIndex = 14;
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(721, 295);
            this.dateTimePickerFechaInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(471, 22);
            this.dateTimePickerFechaInicio.TabIndex = 13;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(717, 526);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(53, 16);
            this.labelEstado.TabIndex = 9;
            this.labelEstado.Text = "Estado:";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(-3, 412);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(82, 16);
            this.labelDescripcion.TabIndex = 12;
            this.labelDescripcion.Text = "Descripción:";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(1, 297);
            this.textBoxTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(415, 22);
            this.textBoxTitulo.TabIndex = 2;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::TASKILLER.Properties.Resources.LOGO;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 2);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(191, 190);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Location = new System.Drawing.Point(717, 242);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(101, 16);
            this.labelFechaInicio.TabIndex = 8;
            this.labelFechaInicio.Text = "Fecha de inicio:";
            // 
            // buttonEliminarProyecto
            // 
            this.buttonEliminarProyecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminarProyecto.Location = new System.Drawing.Point(863, 743);
            this.buttonEliminarProyecto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEliminarProyecto.Name = "buttonEliminarProyecto";
            this.buttonEliminarProyecto.Size = new System.Drawing.Size(328, 78);
            this.buttonEliminarProyecto.TabIndex = 6;
            this.buttonEliminarProyecto.Text = "Eliminar proyecto";
            this.buttonEliminarProyecto.UseVisualStyleBackColor = true;
            // 
            // labelFechaFinal
            // 
            this.labelFechaFinal.AutoSize = true;
            this.labelFechaFinal.Location = new System.Drawing.Point(717, 377);
            this.labelFechaFinal.Name = "labelFechaFinal";
            this.labelFechaFinal.Size = new System.Drawing.Size(75, 16);
            this.labelFechaFinal.TabIndex = 10;
            this.labelFechaFinal.Text = "Fecha final:";
            // 
            // richTextBoxDescripcion
            // 
            this.richTextBoxDescripcion.Location = new System.Drawing.Point(1, 466);
            this.richTextBoxDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            this.richTextBoxDescripcion.Size = new System.Drawing.Size(415, 260);
            this.richTextBoxDescripcion.TabIndex = 11;
            this.richTextBoxDescripcion.Text = "";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(721, 571);
            this.comboBoxEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(471, 24);
            this.comboBoxEstado.TabIndex = 5;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(-3, 249);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(43, 16);
            this.labelTitulo.TabIndex = 7;
            this.labelTitulo.Text = "Título:";
            // 
            // labelCuentanosProyecto
            // 
            this.labelCuentanosProyecto.AutoSize = true;
            this.labelCuentanosProyecto.Location = new System.Drawing.Point(279, 2);
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
            // EditarEliminarProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1213, 926);
            this.Controls.Add(this.panelInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditarEliminarProyecto";
            this.Text = "¡Edita tu proyecto!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

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
    }
}