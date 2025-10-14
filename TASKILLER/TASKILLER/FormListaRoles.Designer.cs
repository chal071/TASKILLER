namespace TASKILLER
{
    partial class FormListaRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaRoles));
            this.flowLayoutPanelListaRoles = new System.Windows.Forms.FlowLayoutPanel();
            this.labelListaRoles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanelListaRoles
            // 
            this.flowLayoutPanelListaRoles.Location = new System.Drawing.Point(33, 155);
            this.flowLayoutPanelListaRoles.Name = "flowLayoutPanelListaRoles";
            this.flowLayoutPanelListaRoles.Size = new System.Drawing.Size(733, 260);
            this.flowLayoutPanelListaRoles.TabIndex = 0;
            // 
            // labelListaRoles
            // 
            this.labelListaRoles.AutoSize = true;
            this.labelListaRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaRoles.Location = new System.Drawing.Point(250, 84);
            this.labelListaRoles.Name = "labelListaRoles";
            this.labelListaRoles.Size = new System.Drawing.Size(309, 55);
            this.labelListaRoles.TabIndex = 1;
            this.labelListaRoles.Text = "Lista de roles";
            // 
            // FormListaRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelListaRoles);
            this.Controls.Add(this.flowLayoutPanelListaRoles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListaRoles";
            this.Text = "FormListaRoles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelListaRoles;
        private System.Windows.Forms.Label labelListaRoles;
    }
}