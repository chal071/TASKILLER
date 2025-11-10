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
    public partial class ProyectoControl : UserControl
    {
        public ProyectoControl()
        {
            InitializeComponent();
        }
        public void AgregarTareas(List<Tarea> tareas, Proyecto p)
        {
            flowLayoutPanelListaTareas.Controls.Clear();

            foreach (var t in tareas)
            {
                if (t.IdProyecto == p.Id)
                {
                    TareaProyectoControl tareaControl = new TareaProyectoControl();
                    tareaControl.setDatos(t);
                    flowLayoutPanelListaTareas.Controls.Add(tareaControl); // <- aquí agregas el control al panel

                }
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
    }
}
