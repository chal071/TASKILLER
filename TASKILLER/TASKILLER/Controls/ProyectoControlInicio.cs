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
        private System.Windows.Forms.Label labelNumeroTareas;
        private System.Windows.Forms.Label labelCantidadTareas;
        private System.Windows.Forms.Label labelPorcentajeCompletado;
        private System.Windows.Forms.Label labelPorcentaje;
        private System.Windows.Forms.Label labelNombre;

        public ProyectoControlInicio(Datos datos, Proyecto proyecto, Usuario usuario)
        {
            InitializeComponent();
            this.d = datos;
            this.p = proyecto;
            this.u = usuario;
        }

        public void SetDatos(Proyecto p)
        {
            labelNombre.Text = p.Titulo;
            labelFechas.Text = p.FechaFinal.ToString("dd/MM/yyyy");
            labelNumeroTareas.Text = ContarTareas(d.listaTareas, p).ToString();
            labelPorcentaje.Text = ((ContarTareasCompletadas(d.listaTareas, p) * 100) / ContarTareas(d.listaTareas, p)).ToString() + " %";

            labelNombre.Font = new Font("Montserrat", 9, FontStyle.Bold);
            labelFechas.Font = new Font("Montserrat", 9, FontStyle.Regular);
            labelCantidadTareas.Font = new Font("Montserrat", 9, FontStyle.Regular);
            labelNumeroTareas.Font = new Font("Montserrat", 9, FontStyle.Regular);
            labelPorcentajeCompletado.Font = new Font("Montserrat", 9, FontStyle.Regular);
            labelPorcentaje.Font = new Font("Montserrat", 9, FontStyle.Bold);
            labelNombre.MaximumSize = new Size(250, 150);
            labelNombre.BackColor = Color.Pink;

            buttonEditar.BackgroundImageLayout = ImageLayout.Zoom;
        }

        public int ContarTareas(List<Tarea> tareas, Proyecto p)
        {
            int contador = 0;

            foreach (var t in tareas)
            {
                if (t.IdProyecto == p.Id)
                {
                    contador++;
                }
            }
            return contador;
        }

        public int ContarTareasCompletadas(List<Tarea> tareas, Proyecto p)
        {
            int contadorCompletadas = 0;

            foreach (var t in tareas)
            {
                if (t.IdProyecto == p.Id)
                {
                    if (t.Estado == Estado.Revisado)
                    { 
                    contadorCompletadas++;
                    }
                }
            }
            return contadorCompletadas;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProyectoControlInicio));
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelFechas = new System.Windows.Forms.Label();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.labelNumeroTareas = new System.Windows.Forms.Label();
            this.labelCantidadTareas = new System.Windows.Forms.Label();
            this.labelPorcentajeCompletado = new System.Windows.Forms.Label();
            this.labelPorcentaje = new System.Windows.Forms.Label();
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
            this.labelFechas.Location = new System.Drawing.Point(14, 177);
            this.labelFechas.Name = "labelFechas";
            this.labelFechas.Size = new System.Drawing.Size(77, 16);
            this.labelFechas.TabIndex = 4;
            this.labelFechas.Text = "Fecha Final";
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditar.BackgroundImage")));
            this.buttonEditar.Location = new System.Drawing.Point(181, 158);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(39, 35);
            this.buttonEditar.TabIndex = 5;
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // labelNumeroTareas
            // 
            this.labelNumeroTareas.AutoSize = true;
            this.labelNumeroTareas.Location = new System.Drawing.Point(20, 71);
            this.labelNumeroTareas.Name = "labelNumeroTareas";
            this.labelNumeroTareas.Size = new System.Drawing.Size(129, 16);
            this.labelNumeroTareas.TabIndex = 1;
            this.labelNumeroTareas.Text = "labelNumeroTareas";
            // 
            // labelCantidadTareas
            // 
            this.labelCantidadTareas.AutoSize = true;
            this.labelCantidadTareas.Location = new System.Drawing.Point(20, 46);
            this.labelCantidadTareas.Name = "labelCantidadTareas";
            this.labelCantidadTareas.Size = new System.Drawing.Size(124, 16);
            this.labelCantidadTareas.TabIndex = 6;
            this.labelCantidadTareas.Text = "Cantidad de tareas:";
            // 
            // labelPorcentajeCompletado
            // 
            this.labelPorcentajeCompletado.AutoSize = true;
            this.labelPorcentajeCompletado.Location = new System.Drawing.Point(20, 101);
            this.labelPorcentajeCompletado.Name = "labelPorcentajeCompletado";
            this.labelPorcentajeCompletado.Size = new System.Drawing.Size(150, 16);
            this.labelPorcentajeCompletado.TabIndex = 8;
            this.labelPorcentajeCompletado.Text = "Porcentaje completado:";
            // 
            // labelPorcentaje
            // 
            this.labelPorcentaje.AutoSize = true;
            this.labelPorcentaje.Location = new System.Drawing.Point(20, 126);
            this.labelPorcentaje.Name = "labelPorcentaje";
            this.labelPorcentaje.Size = new System.Drawing.Size(102, 16);
            this.labelPorcentaje.TabIndex = 7;
            this.labelPorcentaje.Text = "labelPorcentaje";
            // 
            // ProyectoControlInicio
            // 
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.labelPorcentajeCompletado);
            this.Controls.Add(this.labelPorcentaje);
            this.Controls.Add(this.labelCantidadTareas);
            this.Controls.Add(this.labelNumeroTareas);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.labelFechas);
            this.Controls.Add(this.labelNombre);
            this.Name = "ProyectoControlInicio";
            this.Size = new System.Drawing.Size(239, 207);
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
