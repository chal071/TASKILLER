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
    public partial class TareaControl : UserControl
    {
        public TareaControl()
        {
            InitializeComponent();
            labelNombreTarea.Font = new Font("Montserrat", 9, FontStyle.Regular);
            labelFechasTarea.Font = new Font("Montserrat", 9, FontStyle.Regular);
            dataGridViewUsuarioDeTarea.Font = new Font("Montserrat", 8, FontStyle.Regular);
        }

        public void SetDatos(Tarea t)
        {
            labelNombreTarea.Text = t.Titulo;
            dataGridViewUsuarioDeTarea.DataSource = t.listaUsuarios.ToList();
            labelFechasTarea.Text = t.FechaInicio + " - " + t.FechaFinal;
        }
    }
}
