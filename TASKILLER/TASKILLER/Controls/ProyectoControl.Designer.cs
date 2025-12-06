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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProyectoControl));
            this.labelNombre = new System.Windows.Forms.Label();
            this.flowLayoutPanelListaTareas = new System.Windows.Forms.FlowLayoutPanel();
            this.labelFechas = new System.Windows.Forms.Label();
            this.contextMenuStripEditar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.contextMenuStripEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Location = new System.Drawing.Point(23, 20);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(113, 16);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre Proyecto";
            // 
            // flowLayoutPanelListaTareas
            // 
            this.flowLayoutPanelListaTareas.AutoScroll = true;
            this.flowLayoutPanelListaTareas.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelListaTareas.Location = new System.Drawing.Point(26, 68);
            this.flowLayoutPanelListaTareas.Name = "flowLayoutPanelListaTareas";
            this.flowLayoutPanelListaTareas.Size = new System.Drawing.Size(301, 207);
            this.flowLayoutPanelListaTareas.TabIndex = 2;
            // 
            // labelFechas
            // 
            this.labelFechas.AutoSize = true;
            this.labelFechas.Location = new System.Drawing.Point(74, 290);
            this.labelFechas.Name = "labelFechas";
            this.labelFechas.Size = new System.Drawing.Size(159, 16);
            this.labelFechas.TabIndex = 3;
            this.labelFechas.Text = "Fecha inicio - Fecha Final";
            // 
            // contextMenuStripEditar
            // 
            this.contextMenuStripEditar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripEditar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.contextMenuStripEditar.Name = "contextMenuStripEditar";
            this.contextMenuStripEditar.Size = new System.Drawing.Size(137, 56);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = global::TASKILLER.Properties.Resources.editar;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = global::TASKILLER.Properties.Resources.borrar;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditar.BackgroundImage")));
            this.buttonEditar.Location = new System.Drawing.Point(293, 30);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(34, 26);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // ProyectoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelFechas);
            this.Controls.Add(this.flowLayoutPanelListaTareas);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.labelNombre);
            this.Margin = new System.Windows.Forms.Padding(15, 3, 0, 0);
            this.MaximumSize = new System.Drawing.Size(412, 463);
            this.Name = "ProyectoControl";
            this.Size = new System.Drawing.Size(348, 328);
            this.Click += new System.EventHandler(this.ProyectoControl_Click);
            this.contextMenuStripEditar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelListaTareas;
        private System.Windows.Forms.Label labelFechas;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEditar;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}
