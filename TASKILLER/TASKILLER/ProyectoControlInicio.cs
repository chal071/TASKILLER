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
    }
}
