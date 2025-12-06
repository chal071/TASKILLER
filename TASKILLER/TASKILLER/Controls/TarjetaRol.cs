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
            CargarEstilos();
        }

        public void SetDatos(Rol r)
        {
            labelRol.Text = r.Nombre;
            ListBoxAccesoRol.Items.Clear();
            ListBoxAccesoRol.Items.AddRange(r.Acceso.ToArray());
        }

        private void CargarEstilos()
        {
            labelRol.Font = new Font(Fuentes.MontserratBold.FontFamily, 20, FontStyle.Bold);
            labelRol.ForeColor = Color.White;
            ListBoxAccesoRol.Font = new Font(Fuentes.MontserratBold.FontFamily, 12, FontStyle.Bold);

        }

        private void LIstBoxAccesoRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
