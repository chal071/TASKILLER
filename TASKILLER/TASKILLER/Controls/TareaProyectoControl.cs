using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASKILLER
{
    public partial class TareaProyectoControl : UserControl
    {
        public TareaProyectoControl()
        {
            InitializeComponent();
        }


        public void setDatos(Tarea t)
        {

            labelTituloTarea.Font = new Font(Fuentes.MontserratBold.FontFamily, 13, FontStyle.Bold);
            labelEstado.Font = new Font(Fuentes.MontserratBold.FontFamily, 11);

            labelTituloTarea.Text = t.Titulo;

            switch(t.Estado.ToString())
            {
                case "Por_Comenzar":
                    labelEstado.Text = "Por Comenzar 📝";
                    break;
                case "En_Progreso":
                    labelEstado.Text = "En Progreso ⚙️";
                    break;
                case "Entregado": 
                     labelEstado.Text = "Entregado ✅";
                    break;
                case "Revisado":
                    labelEstado.Text = "Revisado 🔍";
                    break;
                case "Bloqueado":
                        labelEstado.Text = "Bloqueado 🔒";
                    break;
                default:
                    labelEstado.Text = t.Estado.ToString();
                    break;
            }

            switch (t.Prioridad)
            {
                case Prioridad.Baja:
                    pictureBoxPrioridad.Image = Properties.Resources.prioridadBaja;
                    pictureBoxPrioridad.SizeMode = PictureBoxSizeMode.Zoom;
                    break;

                case Prioridad.Media:
                    pictureBoxPrioridad.Image = Properties.Resources.prioridadMedia;
                    pictureBoxPrioridad.SizeMode = PictureBoxSizeMode.Zoom;
                    break;

                case Prioridad.Alta:
                    pictureBoxPrioridad.Image = Properties.Resources.prioridadAlta;
                    pictureBoxPrioridad.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
            }
        }

        private void labelTituloTarea_Click(object sender, EventArgs e)
        {

        }

        private void labelEstado_Click(object sender, EventArgs e)
        {

        }

        private void TareaProyectoControl_Load(object sender, EventArgs e)
        {

        }
    }
}
