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
    public partial class TarjetaRol : UserControl
    {
        public TarjetaRol()
        {
            InitializeComponent();
        }

        public void SetDatos(Rol r)
        {
            LIstBoxAccesoRol.Items.Clear();
            LIstBoxAccesoRol.Items.AddRange(r.Acceso.ToArray());
        }

        private void LIstBoxAccesoRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelRol.Text = r.Nombre;
            LIstBoxAccesoRol.Items.Clear();
            LIstBoxAccesoRol.Items.AddRange(r.Acceso.ToArray());
        }
    }
}
