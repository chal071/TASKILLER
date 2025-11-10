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
        public FormCreacionUsuario(Datos datos)
        {
            InitializeComponent();
            this.Resize += Form1_Resize;
            this.d = datos;

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

        private void inicioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormInicio f = new FormInicio(d);
            f.Show();
            this.Hide();
        }

        private void proyectosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormListaProyectos f = new FormListaProyectos(d);
            f.Show();
            this.Hide();
        }

        private void usuariosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormListaUsuarios f = new FormListaUsuarios(d);
            f.Show();
            this.Hide();
        }

        private void rolesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormListaRoles f = new FormListaRoles(d);
            f.Show();
            this.Hide();
        }

        private void crearNuevoProyectoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormCrearProyecto f = new FormCrearProyecto(d);
            f.Show();
            this.Hide();
        }
        private void crearNuevoUsuarioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormCreacionUsuario f = new FormCreacionUsuario(d);
            f.Show();
            this.Hide();
        }

        private void modificarUnRolToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormEdicionRoles f = new FormEdicionRoles(d);
            f.Show();
            this.Hide();
        }

        private void modificarEliminarProyectoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormEditarEliminarProyecto f = new FormEditarEliminarProyecto(d);
            f.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
