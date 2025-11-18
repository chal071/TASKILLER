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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelFechasTarea = new System.Windows.Forms.Label();
            this.labelNombreTarea = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewUsuarioDeTarea = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Icono = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelEstado = new System.Windows.Forms.Panel();
            this.grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarioDeTarea)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFechasTarea
            // 
            this.labelFechasTarea.AutoSize = true;
            this.labelFechasTarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFechasTarea.Location = new System.Drawing.Point(3, 249);
            this.labelFechasTarea.Name = "labelFechasTarea";
            this.labelFechasTarea.Size = new System.Drawing.Size(352, 31);
            this.labelFechasTarea.TabIndex = 2;
            this.labelFechasTarea.Text = "labelFechasTarea";
            this.labelFechasTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNombreTarea
            // 
            this.labelNombreTarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNombreTarea.Location = new System.Drawing.Point(3, 0);
            this.labelNombreTarea.Name = "labelNombreTarea";
            this.labelNombreTarea.Size = new System.Drawing.Size(352, 93);
            this.labelNombreTarea.TabIndex = 1;
            this.labelNombreTarea.Text = "labelNombreTarea";
            this.labelNombreTarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNombreTarea.UseCompatibleTextRendering = true;
            // 
            // grid
            // 
            this.grid.ColumnCount = 1;
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.grid.Controls.Add(this.labelNombreTarea, 1, 0);
            this.grid.Controls.Add(this.labelFechasTarea, 1, 2);
            this.grid.Controls.Add(this.dataGridViewUsuarioDeTarea, 1, 1);
            this.grid.Controls.Add(this.panelEstado, 0, 3);
            this.grid.Location = new System.Drawing.Point(3, 3);
            this.grid.Name = "grid";
            this.grid.RowCount = 4;
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.grid.Size = new System.Drawing.Size(358, 313);
            this.grid.TabIndex = 0;
            // 
            // dataGridViewUsuarioDeTarea
            // 
            this.dataGridViewUsuarioDeTarea.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUsuarioDeTarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUsuarioDeTarea.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsuarioDeTarea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUsuarioDeTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarioDeTarea.ColumnHeadersVisible = false;
            this.dataGridViewUsuarioDeTarea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Icono});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsuarioDeTarea.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUsuarioDeTarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsuarioDeTarea.Location = new System.Drawing.Point(3, 96);
            this.dataGridViewUsuarioDeTarea.Name = "dataGridViewUsuarioDeTarea";
            this.dataGridViewUsuarioDeTarea.ReadOnly = true;
            this.dataGridViewUsuarioDeTarea.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewUsuarioDeTarea.RowHeadersVisible = false;
            this.dataGridViewUsuarioDeTarea.RowHeadersWidth = 82;
            this.dataGridViewUsuarioDeTarea.RowTemplate.Height = 33;
            this.dataGridViewUsuarioDeTarea.Size = new System.Drawing.Size(352, 150);
            this.dataGridViewUsuarioDeTarea.TabIndex = 5;
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
            // Icono
            // 
            this.Icono.FillWeight = 20F;
            this.Icono.HeaderText = "Icono";
            this.Icono.Image = global::TASKILLER.Properties.Resources.logo_user_ros;
            this.Icono.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Icono.MinimumWidth = 10;
            this.Icono.Name = "Icono";
            this.Icono.ReadOnly = true;
            this.Icono.Width = 200;
            // 
            // panelEstado
            // 
            this.panelEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEstado.Location = new System.Drawing.Point(3, 283);
            this.panelEstado.Name = "panelEstado";
            this.panelEstado.Size = new System.Drawing.Size(352, 27);
            this.panelEstado.TabIndex = 6;
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
            this.Size = new System.Drawing.Size(364, 319);
            this.grid.ResumeLayout(false);
            this.grid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarioDeTarea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel grid;
        private System.Windows.Forms.Label labelNombreTarea;
        private System.Windows.Forms.Label labelFechasTarea;
        private System.Windows.Forms.DataGridView dataGridViewUsuarioDeTarea;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn Icono;
        private System.Windows.Forms.Panel panelEstado;
    }
}
