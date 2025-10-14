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
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonIniciarSesion_Click(object sender, EventArgs e)
        {
            String mail = textBoxMail.Text;
            String password = textBoxPassword.Text;
            if (mail.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Por favor, rellena todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*else
            {
                foreach (Usuario user in Program.usuarios)
                {
                    if (user.getMail().Equals(mail) && user.getPassword().Equals(password))
                    {
                        Program.usuarioActual = user;
                        FormInicio formInicio = new FormInicio();
                        formInicio.Show();
                        this.Hide();
                        return;
                    }
                }
            }*/
        }
    }
}
