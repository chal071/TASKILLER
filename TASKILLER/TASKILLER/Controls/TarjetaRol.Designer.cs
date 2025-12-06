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
            this.ListBoxAccesoRol = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRol.Location = new System.Drawing.Point(16, 14);
            this.labelRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(199, 39);
            this.labelRol.TabIndex = 4;
            this.labelRol.Text = "Nombre Rol";
            // 
            // ListBoxAccesoRol
            // 
            this.ListBoxAccesoRol.FormattingEnabled = true;
            this.ListBoxAccesoRol.ItemHeight = 16;
            this.ListBoxAccesoRol.Location = new System.Drawing.Point(24, 64);
            this.ListBoxAccesoRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListBoxAccesoRol.Name = "ListBoxAccesoRol";
            this.ListBoxAccesoRol.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ListBoxAccesoRol.Size = new System.Drawing.Size(413, 388);
            this.ListBoxAccesoRol.TabIndex = 5;
            this.ListBoxAccesoRol.SelectedIndexChanged += new System.EventHandler(this.LIstBoxAccesoRol_SelectedIndexChanged);
            // 
            // TarjetaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(110)))));
            this.Controls.Add(this.ListBoxAccesoRol);
            this.Controls.Add(this.labelRol);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TarjetaRol";
            this.Size = new System.Drawing.Size(467, 484);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox ListBoxAccesoRol;
    }
}
