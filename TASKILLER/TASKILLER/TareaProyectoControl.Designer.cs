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
            this.SuspendLayout();
            // 
            // labelTituloTarea
            // 
            this.labelTituloTarea.AutoSize = true;
            this.labelTituloTarea.Location = new System.Drawing.Point(38, 77);
            this.labelTituloTarea.Name = "labelTituloTarea";
            this.labelTituloTarea.Size = new System.Drawing.Size(44, 16);
            this.labelTituloTarea.TabIndex = 0;
            this.labelTituloTarea.Text = "label1";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(769, 77);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(44, 16);
            this.labelEstado.TabIndex = 1;
            this.labelEstado.Text = "label1";
            // 
            // TareaProyectoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelTituloTarea);
            this.Name = "TareaProyectoControl";
            this.Size = new System.Drawing.Size(881, 195);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloTarea;
        private System.Windows.Forms.Label labelEstado;
    }
}
