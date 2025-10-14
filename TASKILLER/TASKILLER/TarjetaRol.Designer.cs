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
            this.textBoxNombreRol1 = new System.Windows.Forms.TextBox();
            this.buttonPuntos1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNombreRol1
            // 
            this.textBoxNombreRol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreRol1.Location = new System.Drawing.Point(14, 6);
            this.textBoxNombreRol1.Name = "textBoxNombreRol1";
            this.textBoxNombreRol1.Size = new System.Drawing.Size(135, 26);
            this.textBoxNombreRol1.TabIndex = 2;
            this.textBoxNombreRol1.Text = "Nombre del rol...";
            // 
            // buttonPuntos1
            // 
            this.buttonPuntos1.AccessibleName = "buttonPuntos";
            this.buttonPuntos1.Location = new System.Drawing.Point(197, 6);
            this.buttonPuntos1.Name = "buttonPuntos1";
            this.buttonPuntos1.Size = new System.Drawing.Size(33, 23);
            this.buttonPuntos1.TabIndex = 3;
            this.buttonPuntos1.Text = "· · ·";
            this.buttonPuntos1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // TarjetaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPuntos1);
            this.Controls.Add(this.textBoxNombreRol1);
            this.Name = "TarjetaRol";
            this.Size = new System.Drawing.Size(242, 261);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombreRol1;
        private System.Windows.Forms.Button buttonPuntos1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
