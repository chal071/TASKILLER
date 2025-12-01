using System;
using System.Drawing;
using System.Windows.Forms;

namespace TASKILLER
{
    public partial class FormLogin : Form
    {
        private Datos d;
        public FormLogin(Datos datos)
        {
            InitializeComponent();
            cargarDatos();
            this.d = datos;

        }
        private void cargarDatos()
        {

            labelIniciaSesion.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12, FontStyle.Bold);
            labelConTuCuenta.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12, FontStyle.Regular);
            labelTaskiller.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12, FontStyle.Bold);
            labelMail.Font = new Font(Fuentes.MontserratRegular.FontFamily, 8, FontStyle.Bold);
            labelPassword.Font = new Font(Fuentes.MontserratRegular.FontFamily, 8, FontStyle.Bold);
            linkLabelCredenciales.Font = new Font(Fuentes.MontserratRegular.FontFamily, 8, FontStyle.Regular);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
        }

        private void ButtonIniciarSesion_Click(object sender, EventArgs e)
        {
            String email = textBoxMail.Text;
            String password = textBoxPassword.Text;

            if (email.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Por favor, rellena todos los campos.", "Error de credenciales", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Usuario u in d.listaUsuarios)
                {
                    if (u.Mail == email && u.Contrasena == password)
                    {
                        FormInicio f = new FormInicio(d, u);
                        f.Show();
                        this.Hide();
                    }
                }
            }
        }
    }
}
