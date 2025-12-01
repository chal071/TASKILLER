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
        private Usuario UsuarioActual;

        public FormEdicionUsuario(Usuario usuarioActual, Datos datos, Usuario usuario)
        {
            InitializeComponent();
            this.Resize += FormEdicion_Resize;
            this.d = datos;
            this.u = usuario;
            CargarLayout();

        }

        private void CargarLayout()
        {
            labelEdicionUsuario.Font = new Font("Montserrat", 20, FontStyle.Bold);
            labelNombreEdicionUsuario.Font = new Font("Montserrat", 15, FontStyle.Bold);
            textBoxNombreEdicionUsuario.Font = new Font("Montserrat", 12, FontStyle.Bold);
            labelApellidoEdicionUsuario.Font = new Font("Montserrat", 15, FontStyle.Bold);
            textBoxApellidoEdicionUsuario.Font = new Font("Montserrat", 12, FontStyle.Bold);
            labelCorreoEdicionUsuario.Font = new Font("Montserrat", 15, FontStyle.Bold);
            textBoxCorreoEdicionUsuario.Font = new Font("Montserrat", 12, FontStyle.Bold);
            labelContrasenaEdicionUsuario.Font = new Font("Montserrat", 15, FontStyle.Bold);
            textBoxContrasenaEdicionUsuario.Font = new Font("Montserrat", 12, FontStyle.Bold);
            labelRepContrasenaEdicionUsuario.Font = new Font("Montserrat", 15, FontStyle.Bold);
            textBoxRepContrasenaEdicionUsuario.Font = new Font("Montserrat", 12, FontStyle.Bold);
            labelRolEdicionUsuario.Font = new Font("Montserrat", 15, FontStyle.Bold);
            comboBoxRolEdicionUsuario.Font = new Font("Montserrat", 12, FontStyle.Bold);
            labelAdvertenciaEdicionUsuarios.Font = new Font("Montserrat", 12, FontStyle.Bold);
            buttonEdicionUsuario.Font = new Font("Montserrat", 15, FontStyle.Bold);

        }

        private void FormEdicion_Resize(object sender, EventArgs e)
        {
            panelEdicionUser.Left = (this.ClientSize.Width - panelEdicionUser.Width) / 2;
            panelEdicionUser.Top = (this.ClientSize.Height - panelEdicionUser.Height) / 2;
        }



    }
}
