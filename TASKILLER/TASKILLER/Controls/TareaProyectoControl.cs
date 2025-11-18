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
            labelTituloTarea.Text = t.Titulo;
            labelEstado.Text = t.Estado.ToString();


            labelTituloTarea.BackColor = Color.LightBlue; // o el que prefieras
            labelEstado.BackColor = Color.LightGray;

        } 

    }
}
