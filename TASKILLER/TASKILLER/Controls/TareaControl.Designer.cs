namespace TASKILLER
{
    partial class TareaControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelNombreTarea = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewUsuarioDeTarea = new System.Windows.Forms.DataGridView();
            this.labelFechasTarea = new System.Windows.Forms.Label();
            this.panelEstado = new System.Windows.Forms.Panel();
            this.labelSubtareas = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelTareaPadre = new System.Windows.Forms.Label();
            this.pictureBoxPerioridad = new System.Windows.Forms.PictureBox();
            this.grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarioDeTarea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerioridad)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombreTarea
            // 
            this.labelNombreTarea.Location = new System.Drawing.Point(3, 0);
            this.labelNombreTarea.Name = "labelNombreTarea";
            this.labelNombreTarea.Size = new System.Drawing.Size(314, 100);
            this.labelNombreTarea.TabIndex = 1;
            this.labelNombreTarea.Text = "labelNombreTarea";
            this.labelNombreTarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNombreTarea.UseCompatibleTextRendering = true;
            // 
            // grid
            // 
            this.grid.ColumnCount = 2;
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.grid.Controls.Add(this.labelFechasTarea, 0, 4);
            this.grid.Controls.Add(this.panelEstado, 0, 5);
            this.grid.Controls.Add(this.labelSubtareas, 0, 3);
            this.grid.Controls.Add(this.labelNombreTarea, 0, 0);
            this.grid.Controls.Add(this.dataGridViewUsuarioDeTarea, 0, 1);
            this.grid.Controls.Add(this.labelTareaPadre, 0, 2);
            this.grid.Controls.Add(this.pictureBoxPerioridad, 1, 0);
            this.grid.Location = new System.Drawing.Point(3, 3);
            this.grid.Name = "grid";
            this.grid.RowCount = 6;
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.grid.Size = new System.Drawing.Size(400, 501);
            this.grid.TabIndex = 0;
            // 
            // dataGridViewUsuarioDeTarea
            // 
            this.dataGridViewUsuarioDeTarea.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUsuarioDeTarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUsuarioDeTarea.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsuarioDeTarea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewUsuarioDeTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarioDeTarea.ColumnHeadersVisible = false;
            this.grid.SetColumnSpan(this.dataGridViewUsuarioDeTarea, 2);
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsuarioDeTarea.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewUsuarioDeTarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsuarioDeTarea.Location = new System.Drawing.Point(3, 103);
            this.dataGridViewUsuarioDeTarea.Name = "dataGridViewUsuarioDeTarea";
            this.dataGridViewUsuarioDeTarea.ReadOnly = true;
            this.dataGridViewUsuarioDeTarea.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewUsuarioDeTarea.RowHeadersVisible = false;
            this.dataGridViewUsuarioDeTarea.RowHeadersWidth = 82;
            this.dataGridViewUsuarioDeTarea.RowTemplate.Height = 33;
            this.dataGridViewUsuarioDeTarea.Size = new System.Drawing.Size(394, 194);
            this.dataGridViewUsuarioDeTarea.TabIndex = 5;
            // 
            // labelFechasTarea
            // 
            this.labelFechasTarea.AutoSize = true;
            this.grid.SetColumnSpan(this.labelFechasTarea, 2);
            this.labelFechasTarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFechasTarea.Location = new System.Drawing.Point(3, 425);
            this.labelFechasTarea.Name = "labelFechasTarea";
            this.labelFechasTarea.Size = new System.Drawing.Size(394, 50);
            this.labelFechasTarea.TabIndex = 6;
            this.labelFechasTarea.Text = "labelFechasTarea";
            this.labelFechasTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelEstado
            // 
            this.grid.SetColumnSpan(this.panelEstado, 2);
            this.panelEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEstado.Location = new System.Drawing.Point(3, 478);
            this.panelEstado.Name = "panelEstado";
            this.panelEstado.Size = new System.Drawing.Size(394, 20);
            this.panelEstado.TabIndex = 7;
            // 
            // labelSubtareas
            // 
            this.labelSubtareas.AutoSize = true;
            this.grid.SetColumnSpan(this.labelSubtareas, 2);
            this.labelSubtareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSubtareas.Location = new System.Drawing.Point(3, 375);
            this.labelSubtareas.Name = "labelSubtareas";
            this.labelSubtareas.Size = new System.Drawing.Size(394, 50);
            this.labelSubtareas.TabIndex = 8;
            this.labelSubtareas.Text = "labelSubtareas";
            this.labelSubtareas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 20F;
            this.dataGridViewImageColumn1.HeaderText = "Icono";
            this.dataGridViewImageColumn1.Image = global::TASKILLER.Properties.Resources.logo_user_ros;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 10;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 200;
            // 
            // labelTareaPadre
            // 
            this.labelTareaPadre.AutoSize = true;
            this.grid.SetColumnSpan(this.labelTareaPadre, 2);
            this.labelTareaPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTareaPadre.Location = new System.Drawing.Point(3, 300);
            this.labelTareaPadre.Name = "labelTareaPadre";
            this.labelTareaPadre.Size = new System.Drawing.Size(394, 75);
            this.labelTareaPadre.TabIndex = 9;
            this.labelTareaPadre.Text = "Nombre de tarea padre";
            // 
            // pictureBoxPerioridad
            // 
            this.pictureBoxPerioridad.Image = global::TASKILLER.Properties.Resources.prioridadMedia;
            this.pictureBoxPerioridad.Location = new System.Drawing.Point(323, 3);
            this.pictureBoxPerioridad.Name = "pictureBoxPerioridad";
            this.pictureBoxPerioridad.Size = new System.Drawing.Size(74, 94);
            this.pictureBoxPerioridad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPerioridad.TabIndex = 10;
            this.pictureBoxPerioridad.TabStop = false;
            // 
            // TareaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.grid);
            this.Name = "TareaControl";
            this.Size = new System.Drawing.Size(406, 507);
            this.grid.ResumeLayout(false);
            this.grid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarioDeTarea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerioridad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel grid;
        private System.Windows.Forms.Label labelNombreTarea;
        private System.Windows.Forms.DataGridView dataGridViewUsuarioDeTarea;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label labelFechasTarea;
        private System.Windows.Forms.Panel panelEstado;
        private System.Windows.Forms.Label labelSubtareas;
        private System.Windows.Forms.Label labelTareaPadre;
        private System.Windows.Forms.PictureBox pictureBoxPerioridad;
    }
}
