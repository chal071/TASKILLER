using System.Windows.Forms;

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
            this.labelListaProyectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.labelListaProyectos.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelListaProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelListaProyectos.Location = new System.Drawing.Point(0, 0);
            this.labelListaProyectos.Name = "labelListaProyectos";
            this.labelListaProyectos.Size = new System.Drawing.Size(1187, 16);
            this.labelListaProyectos.TabIndex = 0;
            this.labelListaProyectos.Text = "LISTA DE PROYECTOS";
            this.labelListaProyectos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanelListaProyectos
            // 
            this.flowLayoutPanelListaProyectos.AutoScroll = true;
            this.flowLayoutPanelListaProyectos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelListaProyectos.Location = new System.Drawing.Point(0, 104);
            this.flowLayoutPanelListaProyectos.Name = "flowLayoutPanelListaProyectos";
            this.flowLayoutPanelListaProyectos.Size = new System.Drawing.Size(1187, 593);
            this.flowLayoutPanelListaProyectos.TabIndex = 1;
            // 
            // buttonFiltro
            // 
            this.buttonFiltro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFiltro.BackgroundImage")));
            this.buttonFiltro.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(17)))), ((int)(((byte)(92)))));
            this.buttonFiltro.Location = new System.Drawing.Point(1114, 3);
            this.buttonFiltro.Name = "buttonFiltro";
            this.buttonFiltro.Size = new System.Drawing.Size(70, 60);
            this.buttonFiltro.TabIndex = 2;
            this.buttonFiltro.UseVisualStyleBackColor = true;
            // 
            // comboBoxOrdenar
            // 
            this.comboBoxOrdenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.comboBoxOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOrdenar.FormattingEnabled = true;
            this.comboBoxOrdenar.Location = new System.Drawing.Point(845, 3);
            this.comboBoxOrdenar.Name = "comboBoxOrdenar";
            this.comboBoxOrdenar.Size = new System.Drawing.Size(263, 39);
            this.comboBoxOrdenar.TabIndex = 3;
            this.comboBoxOrdenar.Text = "Ordenar por ";
            // 
            // flowLayoutPanelBotonesOrdFil
            // 
            this.flowLayoutPanelBotonesOrdFil.Controls.Add(this.buttonFiltro);
            this.flowLayoutPanelBotonesOrdFil.Controls.Add(this.comboBoxOrdenar);
            this.flowLayoutPanelBotonesOrdFil.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelBotonesOrdFil.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelBotonesOrdFil.Location = new System.Drawing.Point(0, 16);
            this.flowLayoutPanelBotonesOrdFil.Margin = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.flowLayoutPanelBotonesOrdFil.Name = "flowLayoutPanelBotonesOrdFil";
            this.flowLayoutPanelBotonesOrdFil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanelBotonesOrdFil.Size = new System.Drawing.Size(1187, 88);
            this.flowLayoutPanelBotonesOrdFil.TabIndex = 4;
            // 
            // ListaProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1187, 697);
            this.Controls.Add(this.flowLayoutPanelListaProyectos);
            this.Controls.Add(this.flowLayoutPanelBotonesOrdFil);
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