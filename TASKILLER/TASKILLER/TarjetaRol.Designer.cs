namespace TASKILLER
{
    partial class TarjetaRol
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
            this.labelRol = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.LIstBoxAccesoRol = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRol.Location = new System.Drawing.Point(12, 11);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(158, 31);
            this.labelRol.TabIndex = 4;
            this.labelRol.Text = "Nombre Rol";
            // 
            // LIstBoxAccesoRol
            // 
            this.LIstBoxAccesoRol.FormattingEnabled = true;
            this.LIstBoxAccesoRol.Location = new System.Drawing.Point(18, 52);
            this.LIstBoxAccesoRol.Name = "LIstBoxAccesoRol";
            this.LIstBoxAccesoRol.Size = new System.Drawing.Size(207, 186);
            this.LIstBoxAccesoRol.TabIndex = 5;
            // 
            // TarjetaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LIstBoxAccesoRol);
            this.Controls.Add(this.labelRol);
            this.Name = "TarjetaRol";
            this.Size = new System.Drawing.Size(242, 261);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox LIstBoxAccesoRol;
    }
}
