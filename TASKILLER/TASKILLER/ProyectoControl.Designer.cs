namespace TASKILLER
{
    partial class ProyectoControl
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.flowLayoutPanelListaTareas = new System.Windows.Forms.FlowLayoutPanel();
            this.labelFechas = new System.Windows.Forms.Label();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(23, 30);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(113, 16);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre Proyecto";
            // 
            // flowLayoutPanelListaTareas
            // 
            this.flowLayoutPanelListaTareas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanelListaTareas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelListaTareas.Location = new System.Drawing.Point(26, 67);
            this.flowLayoutPanelListaTareas.Name = "flowLayoutPanelListaTareas";
            this.flowLayoutPanelListaTareas.Size = new System.Drawing.Size(368, 334);
            this.flowLayoutPanelListaTareas.TabIndex = 2;
            // 
            // labelFechas
            // 
            this.labelFechas.AutoSize = true;
            this.labelFechas.Location = new System.Drawing.Point(168, 414);
            this.labelFechas.Name = "labelFechas";
            this.labelFechas.Size = new System.Drawing.Size(159, 16);
            this.labelFechas.TabIndex = 3;
            this.labelFechas.Text = "Fecha inicio - Fecha Final";
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(355, 21);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(39, 35);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // ProyectoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelFechas);
            this.Controls.Add(this.flowLayoutPanelListaTareas);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.labelNombre);
            this.Name = "ProyectoControl";
            this.Size = new System.Drawing.Size(412, 463);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelListaTareas;
        private System.Windows.Forms.Label labelFechas;
        private System.Windows.Forms.Button buttonEditar;
    }
}
