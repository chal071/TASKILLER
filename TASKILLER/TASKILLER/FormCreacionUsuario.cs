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

        private void panelCreacionUser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
