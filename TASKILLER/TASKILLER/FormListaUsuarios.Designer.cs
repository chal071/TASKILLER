namespace TASKILLER
{
    partial class FormListaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaUsuarios));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelListaDeUsuarios = new System.Windows.Forms.Label();
            this.dataGridViewListaUsuarios = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelListaDeUsuarios, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewListaUsuarios, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1635, 932);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelListaDeUsuarios
            // 
            this.labelListaDeUsuarios.AutoSize = true;
            this.labelListaDeUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelListaDeUsuarios.Location = new System.Drawing.Point(3, 93);
            this.labelListaDeUsuarios.Name = "labelListaDeUsuarios";
            this.labelListaDeUsuarios.Size = new System.Drawing.Size(1629, 93);
            this.labelListaDeUsuarios.TabIndex = 0;
            this.labelListaDeUsuarios.Text = "Lista de Usuarios";
            this.labelListaDeUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewListaUsuarios
            // 
            this.dataGridViewListaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListaUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewListaUsuarios.Location = new System.Drawing.Point(3, 189);
            this.dataGridViewListaUsuarios.Name = "dataGridViewListaUsuarios";
            this.dataGridViewListaUsuarios.RowHeadersVisible = false;
            this.dataGridViewListaUsuarios.RowHeadersWidth = 82;
            this.dataGridViewListaUsuarios.RowTemplate.Height = 33;
            this.dataGridViewListaUsuarios.Size = new System.Drawing.Size(1629, 740);
            this.dataGridViewListaUsuarios.TabIndex = 1;
            // 
            // FormListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1635, 932);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListaUsuarios";
            this.Text = "FormListaUsuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelListaDeUsuarios;
        private System.Windows.Forms.DataGridView dataGridViewListaUsuarios;
    }
}