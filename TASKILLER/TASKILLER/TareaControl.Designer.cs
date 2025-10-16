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
            this.labelNombreTarea = new System.Windows.Forms.Label();
            this.dataGridViewUsuarioDeTarea = new System.Windows.Forms.DataGridView();
            this.labelFechasTarea = new System.Windows.Forms.Label();
            this.IconoUsuario = new System.Windows.Forms.DataGridViewImageColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarioDeTarea)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombreTarea
            // 
            this.labelNombreTarea.AutoSize = true;
            this.labelNombreTarea.Location = new System.Drawing.Point(30, 39);
            this.labelNombreTarea.Name = "labelNombreTarea";
            this.labelNombreTarea.Size = new System.Drawing.Size(163, 25);
            this.labelNombreTarea.TabIndex = 0;
            this.labelNombreTarea.Text = "(Nombre Tarea)";
            // 
            // dataGridViewUsuarioDeTarea
            // 
            this.dataGridViewUsuarioDeTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarioDeTarea.ColumnHeadersVisible = false;
            this.dataGridViewUsuarioDeTarea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IconoUsuario,
            this.NombreUsuario});
            this.dataGridViewUsuarioDeTarea.Location = new System.Drawing.Point(35, 104);
            this.dataGridViewUsuarioDeTarea.Name = "dataGridViewUsuarioDeTarea";
            this.dataGridViewUsuarioDeTarea.RowHeadersVisible = false;
            this.dataGridViewUsuarioDeTarea.RowHeadersWidth = 82;
            this.dataGridViewUsuarioDeTarea.RowTemplate.Height = 33;
            this.dataGridViewUsuarioDeTarea.Size = new System.Drawing.Size(505, 265);
            this.dataGridViewUsuarioDeTarea.TabIndex = 1;
            // 
            // labelFechasTarea
            // 
            this.labelFechasTarea.AutoSize = true;
            this.labelFechasTarea.Location = new System.Drawing.Point(161, 431);
            this.labelFechasTarea.Name = "labelFechasTarea";
            this.labelFechasTarea.Size = new System.Drawing.Size(239, 25);
            this.labelFechasTarea.TabIndex = 2;
            this.labelFechasTarea.Text = "fecha inicio - fecha final";
            // 
            // IconoUsuario
            // 
            this.IconoUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IconoUsuario.HeaderText = "Icono";
            this.IconoUsuario.MinimumWidth = 10;
            this.IconoUsuario.Name = "IconoUsuario";
            this.IconoUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IconoUsuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IconoUsuario.Width = 33;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreUsuario.DataPropertyName = "Nombre";
            this.NombreUsuario.HeaderText = "Nombre";
            this.NombreUsuario.MinimumWidth = 10;
            this.NombreUsuario.Name = "NombreUsuario";
            // 
            // TareaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelFechasTarea);
            this.Controls.Add(this.dataGridViewUsuarioDeTarea);
            this.Controls.Add(this.labelNombreTarea);
            this.Name = "TareaControl";
            this.Size = new System.Drawing.Size(586, 513);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarioDeTarea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombreTarea;
        private System.Windows.Forms.DataGridView dataGridViewUsuarioDeTarea;
        private System.Windows.Forms.Label labelFechasTarea;
        private System.Windows.Forms.DataGridViewImageColumn IconoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
    }
}
