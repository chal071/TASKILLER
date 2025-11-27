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
        private Datos d;
        private Proyecto p;
        private Usuario u;
        private System.Windows.Forms.Label labelFechas;
        private Button buttonEditar;
        private FlowLayoutPanel flowLayoutPanelNumeroTareas;
        private System.Windows.Forms.Label labelCantidadTareas;
        private System.Windows.Forms.Label labelNumeroTareas;
        private System.Windows.Forms.Label labelNombre;

        public ProyectoControlInicio(Datos datos, Proyecto proyecto, Usuario usuario)
        {
            InitializeComponent();
            this.d = datos;
            this.p = proyecto;
            this.u = usuario;
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
            labelFechas.Text = p.FechaFinal.ToString("dd/MM/yyyy");

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
            this.labelCantidadTareas = new System.Windows.Forms.Label();
            this.labelNumeroTareas = new System.Windows.Forms.Label();
            this.flowLayoutPanelNumeroTareas.SuspendLayout();
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
            this.labelFechas.Location = new System.Drawing.Point(14, 121);
            this.labelFechas.Name = "labelFechas";
            this.labelFechas.Size = new System.Drawing.Size(77, 16);
            this.labelFechas.TabIndex = 4;
            this.labelFechas.Text = "Fecha Final";
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditar.BackgroundImage")));
            this.buttonEditar.Location = new System.Drawing.Point(185, 102);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(39, 35);
            this.buttonEditar.TabIndex = 5;
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // flowLayoutPanelNumeroTareas
            // 
            this.flowLayoutPanelNumeroTareas.BackColor = System.Drawing.Color.MediumTurquoise;
            this.flowLayoutPanelNumeroTareas.Controls.Add(this.labelCantidadTareas);
            this.flowLayoutPanelNumeroTareas.Controls.Add(this.labelNumeroTareas);
            this.flowLayoutPanelNumeroTareas.Location = new System.Drawing.Point(17, 47);
            this.flowLayoutPanelNumeroTareas.Name = "flowLayoutPanelNumeroTareas";
            this.flowLayoutPanelNumeroTareas.Size = new System.Drawing.Size(167, 54);
            this.flowLayoutPanelNumeroTareas.TabIndex = 6;
            // 
            // labelCantidadTareas
            // 
            this.labelCantidadTareas.AutoSize = true;
            this.labelCantidadTareas.Location = new System.Drawing.Point(3, 0);
            this.labelCantidadTareas.Name = "labelCantidadTareas";
            this.labelCantidadTareas.Size = new System.Drawing.Size(121, 16);
            this.labelCantidadTareas.TabIndex = 0;
            this.labelCantidadTareas.Text = "Cantidad de tareas";
            // 
            // labelNumeroTareas
            // 
            this.labelNumeroTareas.AutoSize = true;
            this.labelNumeroTareas.Location = new System.Drawing.Point(3, 16);
            this.labelNumeroTareas.Name = "labelNumeroTareas";
            this.labelNumeroTareas.Size = new System.Drawing.Size(129, 16);
            this.labelNumeroTareas.TabIndex = 1;
            this.labelNumeroTareas.Text = "labelNumeroTareas";
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
            this.flowLayoutPanelNumeroTareas.ResumeLayout(false);
            this.flowLayoutPanelNumeroTareas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            FormEditarEliminarProyecto f = new FormEditarEliminarProyecto(d, p, u);
            f.Show();
            this.Hide();
        }
    }
}
