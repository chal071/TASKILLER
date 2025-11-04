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
    public partial class FormListaRoles : Form
    {
        private Datos d;
        public FormListaRoles(Datos datos)
        {
            InitializeComponent();
            labelListaRoles.Font = new Font("Montserrat", 30, FontStyle.Bold);
            this.d = datos;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
