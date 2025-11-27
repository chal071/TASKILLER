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

            this.Resize += FormEdicion_Resize;

            CargarLayout();
            CargarRoles();
            CargarDatosUsuario();

            buttonEdicionUsuario.Click += buttonEdicionUsuario_Click;
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

        private void CargarRoles()
        {
            comboBoxRolEdicionUsuario.DataSource = d.listaRoles;
            comboBoxRolEdicionUsuario.DisplayMember = "Nombre";
            comboBoxRolEdicionUsuario.ValueMember = "Id";
        }

        private void CargarDatosUsuario()
        {
            textBoxNombreEdicionUsuario.Text = u.Nombre;
            textBoxApellidoEdicionUsuario.Text = u.Apellido;
            textBoxCorreoEdicionUsuario.Text = u.Mail;
            textBoxContrasenaEdicionUsuario.Text = u.Contrasena;
            textBoxRepContrasenaEdicionUsuario.Text = u.Contrasena;
            
            //rol q ya te el user
            if (u.Rol != Guid.Empty)
            {
                comboBoxRolEdicionUsuario.SelectedValue = u.Rol;
            }
        }

        private void buttonEdicionUsuario_Click(object sender, EventArgs e)
        {
            //validar no camps buits
            if (string.IsNullOrWhiteSpace(textBoxNombreEdicionUsuario.Text) ||
                string.IsNullOrWhiteSpace(textBoxApellidoEdicionUsuario.Text) ||
                string.IsNullOrWhiteSpace(textBoxCorreoEdicionUsuario.Text) ||
                string.IsNullOrWhiteSpace(textBoxContrasenaEdicionUsuario.Text))
            {
                labelAdvertenciaEdicionUsuarios.Text = "No puedes dejar campos vacíos.";
            }

            //validar contrñ coinc
            if (textBoxContrasenaEdicionUsuario.Text != textBoxRepContrasenaEdicionUsuario.Text)
            {
                labelAdvertenciaEdicionUsuarios.Text = "Las contraseñas no coinciden.";
            }

            //save canvi
            try
            {
                //override dades usr
                u.Nombre = textBoxNombreEdicionUsuario.Text;
                u.Apellido = textBoxApellidoEdicionUsuario.Text;
                u.Mail = textBoxCorreoEdicionUsuario.Text;
                u.Contrasena = textBoxContrasenaEdicionUsuario.Text;

                //actu rol
                if (comboBoxRolEdicionUsuario.SelectedValue != null)
                {
                    u.Rol = (Guid)comboBoxRolEdicionUsuario.SelectedValue;
                }
                
                //misj yeyyy
                MessageBox.Show("Usuario actualizado correctamente.");
                FormListaUsuarios f = new FormListaUsuarios(d, u);
                f.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                //msj nope yey
                MessageBox.Show("Error al guardar cambios: " + ex.Message);
            }
        }


    }
}
