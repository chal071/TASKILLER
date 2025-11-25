namespace TASKILLER
{
    partial class TareaProyectoControl
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
            this.labelTituloTarea = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.pictureBoxPrioridad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrioridad)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTituloTarea
            // 
            this.labelTituloTarea.AutoSize = true;
            this.labelTituloTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloTarea.Location = new System.Drawing.Point(10, 9);
            this.labelTituloTarea.Name = "labelTituloTarea";
            this.labelTituloTarea.Size = new System.Drawing.Size(50, 16);
            this.labelTituloTarea.TabIndex = 0;
            this.labelTituloTarea.Text = "label1";
            this.labelTituloTarea.Click += new System.EventHandler(this.labelTituloTarea_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(13, 36);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(44, 16);
            this.labelEstado.TabIndex = 1;
            this.labelEstado.Text = "label1";
            this.labelEstado.Click += new System.EventHandler(this.labelEstado_Click);
            // 
            // pictureBoxPrioridad
            // 
            this.pictureBoxPrioridad.Location = new System.Drawing.Point(233, 32);
            this.pictureBoxPrioridad.Name = "pictureBoxPrioridad";
            this.pictureBoxPrioridad.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxPrioridad.TabIndex = 2;
            this.pictureBoxPrioridad.TabStop = false;
            // 
            // TareaProyectoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(211)))));
            this.Controls.Add(this.pictureBoxPrioridad);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelTituloTarea);
            this.Name = "TareaProyectoControl";
            this.Size = new System.Drawing.Size(174, 36);
            this.Load += new System.EventHandler(this.TareaProyectoControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrioridad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloTarea;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.PictureBox pictureBoxPrioridad;
    }
}
