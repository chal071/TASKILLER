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
    public partial class FormCreacionUsuario : Form
    {
        private Datos d;
        private Usuario u;
        public FormCreacionUsuario(Datos datos, Usuario usuario)
        {
            InitializeComponent();
            this.Resize += Form1_Resize;
            this.d = datos;
            this.u= usuario;

            labelCreaUsuario.Font = new Font("Montserrat", 20, FontStyle.Bold);
            labelNombreUsuario.Font = new Font("Montserrat", 15, FontStyle.Bold);
            textBoxNombreUsuario.Font = new Font("Montserrat", 12, FontStyle.Bold);
            labelApellidoUsuario.Font = new Font("Montserrat", 15, FontStyle.Bold);
            textBoxApellidoUsuario.Font = new Font("Montserrat", 12, FontStyle.Bold);
            labelCorreoUsuario.Font = new Font("Montserrat", 15, FontStyle.Bold);
            textBoxCorreoUsuario.Font = new Font("Montserrat", 12, FontStyle.Bold);
            labelContrasenaUsuario.Font = new Font("Montserrat", 15, FontStyle.Bold);
            textBoxContrasenaUsuario.Font = new Font("Montserrat", 12, FontStyle.Bold);
            labelRepContrasenaUsuario.Font = new Font("Montserrat", 15, FontStyle.Bold);
            textBoxRepContrasenaUsuario.Font = new Font("Montserrat", 12, FontStyle.Bold);
            labelRolUsuario.Font = new Font("Montserrat", 15, FontStyle.Bold);
            comboBoxRolUsuario.Font = new Font("Montserrat", 12, FontStyle.Bold);
            labelAdvertenciaCreacionUsuarios.Font = new Font("Montserrat", 12, FontStyle.Bold);
            buttonCrearUsuario.Font = new Font("Montserrat", 15, FontStyle.Bold);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panelCreacionUser.Left = (this.ClientSize.Width - panelCreacionUser.Width) / 2;
            panelCreacionUser.Top = (this.ClientSize.Height - panelCreacionUser.Height) / 2;
        }

        private void panelCreacionUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormCreaciónUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
