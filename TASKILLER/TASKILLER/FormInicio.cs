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
