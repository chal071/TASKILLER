using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TASKILLER
{
    public partial class FormListaTareas : Form
    {
        private Datos d;
        public FormListaTareas(Datos datos)
        {
            InitializeComponent();
            setFontSize();
            this.d = datos;
        }




        private void setFontSize() 
        {
            labelTarea.Font = new Font(Fuentes.MontserratBold.FontFamily, 30);
            dataGridViewTareas.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12);
            labelPorComenzar.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            labelEnProgreso.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            labelEntregado.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            labelRevisado.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            labelBloqueado.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
        }
    }
}