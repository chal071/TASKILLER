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
            this.Resize += Form1_Resize;
            labelListaRoles.Font = new Font("Montserrat", 30, FontStyle.Bold);
            this.d = datos;
            foreach (Rol r in d.listaRoles) 
            {
                TarjetaRol rol = new TarjetaRol();
                rol.SetDatos(r);
                flowLayoutPanelListaRoles.Controls.Add(rol);

            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            panelListaRolesResp.Left = (this.ClientSize.Width - panelListaRolesResp.Width) / 2;
            panelListaRolesResp.Top = (this.ClientSize.Height - panelListaRolesResp.Height) / 2;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
