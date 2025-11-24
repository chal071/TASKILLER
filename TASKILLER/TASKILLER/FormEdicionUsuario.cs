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
    public partial class FormEdicionUsuario : Form
    {
        private Datos d;
        private Usuario u;
        public FormEdicionUsuario(Datos datos, Usuario usuario)
        {
            InitializeComponent();
            this.d = datos;
            this.u = usuario;
        }

        private void PanelEdicionUsuario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelRolEdicionUsuario_Click(object sender, EventArgs e)
        {

        }

    }
}
