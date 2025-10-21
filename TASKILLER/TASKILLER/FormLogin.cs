using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TASKILLER
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            labelIniciaSesion.Font = new Font("Montserrat", 12, FontStyle.Bold);
            labelConTuCuenta.Font = new Font("Montserrat", 12, FontStyle.Regular);
            labelTaskiller.Font = new Font("Montserrat", 12, FontStyle.Bold);
            labelMail.Font = new Font("Montserrat", 8, FontStyle.Bold);
            labelPassword.Font = new Font("Montserrat", 8, FontStyle.Bold);
            linkLabelCredenciales.Font = new Font("Montserrat", 8, FontStyle.Regular);
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
                foreach (Usuario user in Program.usuarios)
                {
                    if (user.Mail.Equals(email) && user.Contrasena.Equals(password))
                    {
                        Program.usuarioActual = user;
                        FormInicio formInicio = new FormInicio();
                        formInicio.Show();
                        this.Hide();
                        return;
                    }
                }
            }
        }
    }
}
