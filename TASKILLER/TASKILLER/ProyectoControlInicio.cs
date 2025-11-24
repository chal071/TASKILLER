using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASKILLER
{
    public partial class ProyectoControlInicio : UserControl
    {
        private System.Windows.Forms.Label labelFechas;
        private Button buttonEditar;
        private FlowLayoutPanel flowLayoutPanelNumeroTareas;
        private System.Windows.Forms.Label labelNombre;

        public ProyectoControlInicio()
        {
            InitializeComponent();
        }

        public void ContarTareas(List<Tarea> tareas, Proyecto p)
        {
            int contador = 0;
            flowLayoutPanelNumeroTareas.Controls.Clear();

            foreach (var t in tareas)
            {
                contador++;
            }
        }

        public void SetDatos(Proyecto p)
        {
            labelNombre.Text = p.Titulo;
            labelFechas.Text = p.FechaInicio + " - " + p.FechaFinal;

            labelNombre.Font = new Font("Montserrat", 9, FontStyle.Bold);
            labelFechas.Font = new Font("Montserrat", 9, FontStyle.Regular);
            labelNombre.MaximumSize = new Size(250, 150);
            labelNombre.BackColor = Color.Pink;

            buttonEditar.BackgroundImageLayout = ImageLayout.Zoom;

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProyectoControlInicio));
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelFechas = new System.Windows.Forms.Label();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.flowLayoutPanelNumeroTareas = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(14, 15);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(113, 16);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre Proyecto";
            // 
            // labelFechas
            // 
            this.labelFechas.AutoSize = true;
            this.labelFechas.Location = new System.Drawing.Point(36, 108);
            this.labelFechas.Name = "labelFechas";
            this.labelFechas.Size = new System.Drawing.Size(77, 16);
            this.labelFechas.TabIndex = 4;
            this.labelFechas.Text = "Fecha Final";
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditar.BackgroundImage")));
            this.buttonEditar.Location = new System.Drawing.Point(182, 15);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(39, 35);
            this.buttonEditar.TabIndex = 5;
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelNumeroTareas
            // 
            this.flowLayoutPanelNumeroTareas.BackColor = System.Drawing.Color.MediumTurquoise;
            this.flowLayoutPanelNumeroTareas.Location = new System.Drawing.Point(65, 49);
            this.flowLayoutPanelNumeroTareas.Name = "flowLayoutPanelNumeroTareas";
            this.flowLayoutPanelNumeroTareas.Size = new System.Drawing.Size(89, 41);
            this.flowLayoutPanelNumeroTareas.TabIndex = 6;
            // 
            // ProyectoControlInicio
            // 
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.flowLayoutPanelNumeroTareas);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.labelFechas);
            this.Controls.Add(this.labelNombre);
            this.Name = "ProyectoControlInicio";
            this.Size = new System.Drawing.Size(237, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
