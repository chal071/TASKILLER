using System;
using System.Drawing;
using System.Windows.Forms;

namespace TASKILLER
{
    public partial class FormInicio : Form
    {
        private Datos d;
        public FormInicio(Datos datos)
        {
            InitializeComponent();
            this.d = datos;
            Helpers.AplicarFuente(this, Fuentes.MontserratRegular);

            this.Resize += Form_Resize;
            this.d = datos;
            setFontSize();
        }
        private void setFontSize()
        {
            labelUltimosProyectos.Font = new Font(Fuentes.MontserratBold.FontFamily, 30);
            labelHoy.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            labelHaceUnaSemana.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
        }
        private void Form_Resize(object sender, EventArgs e)
        {
            panelInicio.Left = (this.ClientSize.Width - panelInicio.Width) / 2;
            panelInicio.Top = (this.ClientSize.Height - panelInicio.Height) / 2;
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
