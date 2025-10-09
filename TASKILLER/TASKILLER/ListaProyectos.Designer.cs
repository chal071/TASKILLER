namespace TASKILLER
{
    partial class ListaProyectos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaProyectos));
            this.labelListaProyectos = new System.Windows.Forms.Label();
            this.flowLayoutPanelListaProyectos = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonFiltro = new System.Windows.Forms.Button();
            this.comboBoxOrdenar = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelBotonesOrdFil = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelBotonesOrdFil.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelListaProyectos
            // 
            this.labelListaProyectos.BackColor = System.Drawing.SystemColors.Control;
            this.labelListaProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelListaProyectos.Location = new System.Drawing.Point(510, 37);
            this.labelListaProyectos.Name = "labelListaProyectos";
            this.labelListaProyectos.Size = new System.Drawing.Size(153, 16);
            this.labelListaProyectos.TabIndex = 0;
            this.labelListaProyectos.Text = "LISTA DE PROYECTOS";
            this.labelListaProyectos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelListaProyectos.Click += new System.EventHandler(this.labelListaProyectos_Click);
            // 
            // flowLayoutPanelListaProyectos
            // 
            this.flowLayoutPanelListaProyectos.Location = new System.Drawing.Point(12, 105);
            this.flowLayoutPanelListaProyectos.Name = "flowLayoutPanelListaProyectos";
            this.flowLayoutPanelListaProyectos.Size = new System.Drawing.Size(1163, 534);
            this.flowLayoutPanelListaProyectos.TabIndex = 1;
            // 
            // buttonFiltro
            // 
            this.buttonFiltro.Location = new System.Drawing.Point(130, 3);
            this.buttonFiltro.Name = "buttonFiltro";
            this.buttonFiltro.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltro.TabIndex = 2;
            this.buttonFiltro.Text = "Filtrar";
            this.buttonFiltro.UseVisualStyleBackColor = true;
            // 
            // comboBoxOrdenar
            // 
            this.comboBoxOrdenar.FormattingEnabled = true;
            this.comboBoxOrdenar.Location = new System.Drawing.Point(3, 3);
            this.comboBoxOrdenar.Name = "comboBoxOrdenar";
            this.comboBoxOrdenar.Size = new System.Drawing.Size(121, 24);
            this.comboBoxOrdenar.TabIndex = 3;
            // 
            // flowLayoutPanelBotonesOrdFil
            // 
            this.flowLayoutPanelBotonesOrdFil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelBotonesOrdFil.Controls.Add(this.comboBoxOrdenar);
            this.flowLayoutPanelBotonesOrdFil.Controls.Add(this.buttonFiltro);
            this.flowLayoutPanelBotonesOrdFil.Location = new System.Drawing.Point(962, 69);
            this.flowLayoutPanelBotonesOrdFil.Name = "flowLayoutPanelBotonesOrdFil";
            this.flowLayoutPanelBotonesOrdFil.Size = new System.Drawing.Size(213, 30);
            this.flowLayoutPanelBotonesOrdFil.TabIndex = 4;
            // 
            // ListaProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 660);
            this.Controls.Add(this.flowLayoutPanelBotonesOrdFil);
            this.Controls.Add(this.flowLayoutPanelListaProyectos);
            this.Controls.Add(this.labelListaProyectos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de proyectos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanelBotonesOrdFil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelListaProyectos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelListaProyectos;
        private System.Windows.Forms.Button buttonFiltro;
        private System.Windows.Forms.ComboBox comboBoxOrdenar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBotonesOrdFil;
    }
}