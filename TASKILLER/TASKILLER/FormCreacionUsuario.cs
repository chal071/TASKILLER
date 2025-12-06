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
            this.d = datos;
            this.u = usuario;
            this.Resize += FormCreacion_Resize;
            CargarEstilos();
            CargarRoles();
            buttonCrearUsuario.Click += buttonCrearUsuario_Click;
        }

        private void CargarEstilos()
        {
            labelCreaUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 20, FontStyle.Bold);
            labelNombreUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 15, FontStyle.Bold);
            textBoxNombreUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 12);
            labelApellidoUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 15, FontStyle.Bold);
            textBoxApellidoUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 12);
            labelCorreoUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 15, FontStyle.Bold);
            textBoxCorreoUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 12);
            labelContrasenaUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 15, FontStyle.Bold);
            textBoxContrasenaUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 12);
            labelRepContrasenaUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 15, FontStyle.Bold);
            textBoxRepContrasenaUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 12);
            labelRolUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 15, FontStyle.Bold);
            comboBoxRolUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 12);
            labelAdvertenciaCreacionUsuarios.Font = new Font(Fuentes.MontserratBold.FontFamily, 12);
            buttonCrearUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 15, FontStyle.Bold);
            toolStripLabelNombre.Text = "Usuario: " + u.Nombre + " " + u.Apellido;
            toolStripLabelNombre.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            toolStripDropDownButton1.Font = new Font(Fuentes.MontserratBold.FontFamily, 12);
        }

        private void FormCreacion_Resize(object sender, EventArgs e)
        {
            panelCreacionUser.Left = (this.ClientSize.Width - panelCreacionUser.Width) / 2;
            panelCreacionUser.Top = (this.ClientSize.Height - panelCreacionUser.Height) / 2;
        }

        private void CargarRoles()
        {
            comboBoxRolUsuario.DataSource = d.listaRoles;
            comboBoxRolUsuario.DisplayMember = "Nombre";
            comboBoxRolUsuario.ValueMember = "Id";
        }

        private void buttonCrearUsuario_Click(object sender, EventArgs e)
        {
            //valid. camp buit
            if (string.IsNullOrWhiteSpace(textBoxNombreUsuario.Text) ||
                string.IsNullOrWhiteSpace(textBoxApellidoUsuario.Text) ||
                string.IsNullOrWhiteSpace(textBoxCorreoUsuario.Text) ||
                string.IsNullOrWhiteSpace(textBoxContrasenaUsuario.Text))
            {
                labelAdvertenciaCreacionUsuarios.Text = "Por favor, rellena todos los campos.";
            }

            //contra iguale
            if (textBoxContrasenaUsuario.Text != textBoxRepContrasenaUsuario.Text)
            {
                labelAdvertenciaCreacionUsuarios.Text = "Las contraseñas no coinciden.";
            }

            //rol
            if (comboBoxRolUsuario.SelectedItem == null)
            {
                labelAdvertenciaCreacionUsuarios.Text = "Debes seleccionar un rol.";
            }

            //crear usur
            try
            {
                Usuario nuevoUsuario = new Usuario();

                //id aut. unic
                nuevoUsuario.Id = Guid.NewGuid();

                //assig. valor caja text
                nuevoUsuario.Nombre = textBoxNombreUsuario.Text;
                nuevoUsuario.Apellido = textBoxApellidoUsuario.Text;
                nuevoUsuario.Mail = textBoxCorreoUsuario.Text;
                nuevoUsuario.Contrasena = textBoxContrasenaUsuario.Text;

                //asiig. id rol seleccionao
                // (SelectedValue nos da lo que pusimos en ValueMember, o sea, el Id)
                nuevoUsuario.Rol = (Guid)comboBoxRolUsuario.SelectedValue;

                //guardar list global
                d.listaUsuarios.Add(nuevoUsuario);

                //mensj exit cierre
                MessageBox.Show("Usuario creado con éxito: " + nuevoUsuario.Nombre);
                FormListaUsuarios f = new FormListaUsuarios(d, u);
                f.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                //mensj error :/
                MessageBox.Show("Ocurrió un error al crear el usuario: " + ex.Message);
            }
    }

        private void inicioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
            FormInicio f = new FormInicio(d, u);
            f.Show();
        }
        private void proyectosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
            FormListaProyectos f = new FormListaProyectos(d, u);
            f.Show();
        }
        private void usuariosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
            FormListaUsuarios f = new FormListaUsuarios(d, u);
            f.Show();
        }
        private void rolesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
            FormListaRoles f = new FormListaRoles(d, u);
            f.Show();
        }
        private void crearNuevoProyectoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
            FormCrearProyecto f = new FormCrearProyecto(d, u);
            f.Show();
        }
        private void crearNuevoUsuarioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Rol r = new Rol();
            r = d.listaRoles.FirstOrDefault(t => t.Nombre == "Administrador");

            if (u.Rol == r.Id)
            {
                FormCreacionUsuario f = new FormCreacionUsuario(d, u);
                f.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No tienes permisos para crear usuarios.", "Permisos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void salirToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void guardarDatosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            GestionDatos.GuardarDatos(d);
        }
    }
}
