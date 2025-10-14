namespace TASKILLER
{
    partial class ListaTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaTareas));
            this.flowLayoutPanelListaTareas = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxTarea = new System.Windows.Forms.GroupBox();
            this.buttonAñadirMasTarea = new System.Windows.Forms.Button();
            this.labelTareas = new System.Windows.Forms.Label();
            this.dataGridViewListasTarea = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelNombreProyecto = new System.Windows.Forms.Label();
            this.groupBoxTareasPorComenzar = new System.Windows.Forms.GroupBox();
            this.groupBoxEnProgreso = new System.Windows.Forms.GroupBox();
            this.groupBoxEntregado = new System.Windows.Forms.GroupBox();
            this.groupBoxRevisado = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelListaEstadoTareas = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelListaTareas.SuspendLayout();
            this.groupBoxTarea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListasTarea)).BeginInit();
            this.flowLayoutPanelListaEstadoTareas.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelListaTareas
            // 
            this.flowLayoutPanelListaTareas.AutoScroll = true;
            this.flowLayoutPanelListaTareas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelListaTareas.Controls.Add(this.groupBoxTarea);
            this.flowLayoutPanelListaTareas.Controls.Add(this.dataGridViewListasTarea);
            this.flowLayoutPanelListaTareas.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelListaTareas.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelListaTareas.Name = "flowLayoutPanelListaTareas";
            this.flowLayoutPanelListaTareas.Size = new System.Drawing.Size(479, 969);
            this.flowLayoutPanelListaTareas.TabIndex = 0;
            // 
            // groupBoxTarea
            // 
            this.groupBoxTarea.Controls.Add(this.buttonAñadirMasTarea);
            this.groupBoxTarea.Controls.Add(this.labelTareas);
            this.groupBoxTarea.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTarea.Name = "groupBoxTarea";
            this.groupBoxTarea.Size = new System.Drawing.Size(465, 100);
            this.groupBoxTarea.TabIndex = 2;
            this.groupBoxTarea.TabStop = false;
            // 
            // buttonAñadirMasTarea
            // 
            this.buttonAñadirMasTarea.Location = new System.Drawing.Point(384, 27);
            this.buttonAñadirMasTarea.Name = "buttonAñadirMasTarea";
            this.buttonAñadirMasTarea.Size = new System.Drawing.Size(66, 64);
            this.buttonAñadirMasTarea.TabIndex = 1;
            this.buttonAñadirMasTarea.Text = "+";
            this.buttonAñadirMasTarea.UseVisualStyleBackColor = true;
            // 
            // labelTareas
            // 
            this.labelTareas.AutoSize = true;
            this.labelTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTareas.Location = new System.Drawing.Point(8, 27);
            this.labelTareas.Name = "labelTareas";
            this.labelTareas.Size = new System.Drawing.Size(216, 55);
            this.labelTareas.TabIndex = 0;
            this.labelTareas.Text = "TAREAS";
            // 
            // dataGridViewListasTarea
            // 
            this.dataGridViewListasTarea.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.dataGridViewListasTarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewListasTarea.CausesValidation = false;
            this.dataGridViewListasTarea.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewListasTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListasTarea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Estado,
            this.Editar});
            this.dataGridViewListasTarea.Location = new System.Drawing.Point(3, 109);
            this.dataGridViewListasTarea.Name = "dataGridViewListasTarea";
            this.dataGridViewListasTarea.RowHeadersVisible = false;
            this.dataGridViewListasTarea.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewListasTarea.RowTemplate.Height = 33;
            this.dataGridViewListasTarea.Size = new System.Drawing.Size(465, 806);
            this.dataGridViewListasTarea.TabIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 10;
            this.Nombre.Name = "Nombre";
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 10;
            this.Estado.Name = "Estado";
            this.Estado.Width = 124;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Editar.HeaderText = "";
            this.Editar.MinimumWidth = 10;
            this.Editar.Name = "Editar";
            this.Editar.Text = "";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 33;
            // 
            // labelNombreProyecto
            // 
            this.labelNombreProyecto.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNombreProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreProyecto.Location = new System.Drawing.Point(479, 0);
            this.labelNombreProyecto.Name = "labelNombreProyecto";
            this.labelNombreProyecto.Size = new System.Drawing.Size(1155, 55);
            this.labelNombreProyecto.TabIndex = 1;
            this.labelNombreProyecto.Text = "(Nombre Proyecto)";
            this.labelNombreProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxTareasPorComenzar
            // 
            this.groupBoxTareasPorComenzar.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTareasPorComenzar.Name = "groupBoxTareasPorComenzar";
            this.groupBoxTareasPorComenzar.Size = new System.Drawing.Size(230, 884);
            this.groupBoxTareasPorComenzar.TabIndex = 2;
            this.groupBoxTareasPorComenzar.TabStop = false;
            this.groupBoxTareasPorComenzar.Text = "Por comenzar";
            // 
            // groupBoxEnProgreso
            // 
            this.groupBoxEnProgreso.Location = new System.Drawing.Point(239, 3);
            this.groupBoxEnProgreso.Name = "groupBoxEnProgreso";
            this.groupBoxEnProgreso.Size = new System.Drawing.Size(230, 884);
            this.groupBoxEnProgreso.TabIndex = 3;
            this.groupBoxEnProgreso.TabStop = false;
            this.groupBoxEnProgreso.Text = "En progreso";
            // 
            // groupBoxEntregado
            // 
            this.groupBoxEntregado.Location = new System.Drawing.Point(475, 3);
            this.groupBoxEntregado.Name = "groupBoxEntregado";
            this.groupBoxEntregado.Size = new System.Drawing.Size(230, 884);
            this.groupBoxEntregado.TabIndex = 3;
            this.groupBoxEntregado.TabStop = false;
            this.groupBoxEntregado.Text = "Entregado";
            // 
            // groupBoxRevisado
            // 
            this.groupBoxRevisado.Location = new System.Drawing.Point(711, 3);
            this.groupBoxRevisado.Name = "groupBoxRevisado";
            this.groupBoxRevisado.Size = new System.Drawing.Size(230, 884);
            this.groupBoxRevisado.TabIndex = 3;
            this.groupBoxRevisado.TabStop = false;
            this.groupBoxRevisado.Text = "Revisado";
            // 
            // flowLayoutPanelListaEstadoTareas
            // 
            this.flowLayoutPanelListaEstadoTareas.AutoScroll = true;
            this.flowLayoutPanelListaEstadoTareas.Controls.Add(this.groupBoxTareasPorComenzar);
            this.flowLayoutPanelListaEstadoTareas.Controls.Add(this.groupBoxEnProgreso);
            this.flowLayoutPanelListaEstadoTareas.Controls.Add(this.groupBoxEntregado);
            this.flowLayoutPanelListaEstadoTareas.Controls.Add(this.groupBoxRevisado);
            this.flowLayoutPanelListaEstadoTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelListaEstadoTareas.Location = new System.Drawing.Point(479, 55);
            this.flowLayoutPanelListaEstadoTareas.Name = "flowLayoutPanelListaEstadoTareas";
            this.flowLayoutPanelListaEstadoTareas.Size = new System.Drawing.Size(1155, 914);
            this.flowLayoutPanelListaEstadoTareas.TabIndex = 4;
            // 
            // ListaTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1634, 969);
            this.Controls.Add(this.flowLayoutPanelListaEstadoTareas);
            this.Controls.Add(this.labelNombreProyecto);
            this.Controls.Add(this.flowLayoutPanelListaTareas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaTareas";
            this.Text = "Tareas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanelListaTareas.ResumeLayout(false);
            this.groupBoxTarea.ResumeLayout(false);
            this.groupBoxTarea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListasTarea)).EndInit();
            this.flowLayoutPanelListaEstadoTareas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelListaTareas;
        private System.Windows.Forms.Label labelTareas;
        private System.Windows.Forms.DataGridView dataGridViewListasTarea;
        private System.Windows.Forms.GroupBox groupBoxTarea;
        private System.Windows.Forms.Button buttonAñadirMasTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.Label labelNombreProyecto;
        private System.Windows.Forms.GroupBox groupBoxTareasPorComenzar;
        private System.Windows.Forms.GroupBox groupBoxEnProgreso;
        private System.Windows.Forms.GroupBox groupBoxEntregado;
        private System.Windows.Forms.GroupBox groupBoxRevisado;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelListaEstadoTareas;
    }
}