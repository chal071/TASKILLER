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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelListaRolesResp = new System.Windows.Forms.Panel();
            this.panelListaRolesResp.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelListaRoles
            // 
            this.flowLayoutPanelListaRoles.AutoScroll = true;
            this.flowLayoutPanelListaRoles.Location = new System.Drawing.Point(44, 121);
            this.flowLayoutPanelListaRoles.Name = "flowLayoutPanelListaRoles";
            this.flowLayoutPanelListaRoles.Size = new System.Drawing.Size(733, 260);
            this.flowLayoutPanelListaRoles.TabIndex = 0;
            // 
            // labelListaRoles
            // 
            this.labelListaRoles.AutoSize = true;
            this.labelListaRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaRoles.Location = new System.Drawing.Point(261, 50);
            this.labelListaRoles.Name = "labelListaRoles";
            this.labelListaRoles.Size = new System.Drawing.Size(309, 55);
            this.labelListaRoles.TabIndex = 1;
            this.labelListaRoles.Text = "Lista de roles";
            // 
            // panelListaRolesResp
            // 
            this.panelListaRolesResp.Controls.Add(this.labelListaRoles);
            this.panelListaRolesResp.Controls.Add(this.flowLayoutPanelListaRoles);
            this.panelListaRolesResp.Location = new System.Drawing.Point(46, 47);
            this.panelListaRolesResp.Name = "panelListaRolesResp";
            this.panelListaRolesResp.Size = new System.Drawing.Size(824, 419);
            this.panelListaRolesResp.TabIndex = 2;
            // 
            // FormListaRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 630);
            this.Controls.Add(this.panelListaRolesResp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListaRoles";
            this.Text = "FormListaRoles";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelListaRolesResp.ResumeLayout(false);
            this.panelListaRolesResp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelListaRoles;
        private System.Windows.Forms.Label labelListaRoles;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelListaRolesResp;
    }
}