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
            this.d = datos;
            this.u = usuario;
            this.UsuarioActual = usuarioActual;

            this.Resize += FormEdicion_Resize;

            CargarLayout();
            CargarRoles();
            CargarDatosUsuario();

            buttonEdicionUsuario.Click += buttonEdicionUsuario_Click;
        }

        private void CargarLayout()
        {
            labelEdicionUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 20, FontStyle.Bold);
            labelNombreEdicionUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 15, FontStyle.Bold);
            textBoxNombreEdicionUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 12);
            labelApellidoEdicionUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 15, FontStyle.Bold);
            textBoxApellidoEdicionUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 12);
            labelCorreoEdicionUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 15, FontStyle.Bold);
            textBoxCorreoEdicionUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 12);
            labelContrasenaEdicionUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 15, FontStyle.Bold);
            textBoxContrasenaEdicionUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 12);
            labelRepContrasenaEdicionUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 15, FontStyle.Bold);
            textBoxRepContrasenaEdicionUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 12);
            labelRolEdicionUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 15, FontStyle.Bold);
            comboBoxRolEdicionUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 12);
            labelAdvertenciaEdicionUsuarios.Font = new Font(Fuentes.MontserratBold.FontFamily, 9);
            buttonEdicionUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 15, FontStyle.Bold);
            buttonEliminarUsuario.Font = new Font(Fuentes.MontserratBold.FontFamily, 15, FontStyle.Bold);
            toolStripDropDownButton1.Font = new Font(Fuentes.MontserratBold.FontFamily, 12);
            toolStripLabelNombre.Text = "Usuario: " + u.Nombre + " " + u.Apellido;
            toolStripLabelNombre.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);

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
            textBoxNombreEdicionUsuario.Text = UsuarioActual.Nombre;
            textBoxApellidoEdicionUsuario.Text = UsuarioActual.Apellido;
            textBoxCorreoEdicionUsuario.Text = UsuarioActual.Mail;
            textBoxContrasenaEdicionUsuario.Text = UsuarioActual.Contrasena;
            textBoxRepContrasenaEdicionUsuario.Text = UsuarioActual.Contrasena;
            
            //rol q ya te el user
            if (UsuarioActual.Rol != Guid.Empty)
            {
                comboBoxRolEdicionUsuario.SelectedValue = UsuarioActual.Rol;
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
                UsuarioActual.Nombre = textBoxNombreEdicionUsuario.Text;
                UsuarioActual.Apellido = textBoxApellidoEdicionUsuario.Text;
                UsuarioActual.Mail = textBoxCorreoEdicionUsuario.Text;
                UsuarioActual.Contrasena = textBoxContrasenaEdicionUsuario.Text;

                //actu rol
                if (comboBoxRolEdicionUsuario.SelectedValue != null)
                {
                    UsuarioActual.Rol = (Guid)comboBoxRolEdicionUsuario.SelectedValue;
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

        private void inicioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormInicio f = new FormInicio(d, u);
            f.Show();
            this.Close();
        }
        private void proyectosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormListaProyectos f = new FormListaProyectos(d, u);
            f.Show();
            this.Close();
        }
        private void usuariosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormListaUsuarios f = new FormListaUsuarios(d, u);
            f.Show();
            this.Close();
        }
        private void rolesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormListaRoles f = new FormListaRoles(d, u);
            f.Show();
            this.Close();
        }
        private void crearNuevoProyectoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormCrearProyecto f = new FormCrearProyecto(d, u);
            f.Show();
            this.Close();
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
        private void guardarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionDatos.GuardarDatos(d);
        }
        private void salirToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void buttonbuttonEliminarUsuario_Click(object sender, EventArgs e)
        {

            var r = MessageBox.Show("¿Seguro que quieres eliminar este usuario?",
                                    "Confirmar",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                d.listaUsuarios.Remove(UsuarioActual);
                MessageBox.Show("Usuario eliminado correctamente.");
                FormListaUsuarios f = new FormListaUsuarios(d, u);
                f.Show();
                this.Close();
            }
        }
    }
}
