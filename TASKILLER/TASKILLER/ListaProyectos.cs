using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASKILLER
{
    public partial class ListaProyectos : Form
    {
        public ListaProyectos()
        {
            InitializeComponent();
            comboBoxOrdenar.Text = "Ordenar por ";
            

            PrivateFontCollection pfc = new PrivateFontCollection();
            string fontPath = Path.Combine(Application.StartupPath, "res", "Montserrat-Light.ttf");
            pfc.AddFontFile(fontPath);

            labelListaProyectos.Font = new Font(pfc.Families[0], 30, FontStyle.Regular);

            labelListaProyectos.TextAlign = ContentAlignment.MiddleCenter;

        }

        private void labelListaProyectos_Click(object sender, EventArgs e)
        {

        }
    }
}
