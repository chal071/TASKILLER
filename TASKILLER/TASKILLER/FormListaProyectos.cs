
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TASKILLER
{
    public partial class FormListaProyectos : Form
    {
        private Datos d;
        public FormListaProyectos(Datos datos)
        {
            InitializeComponent();
            this.d = datos;
            flowLayoutPanelListaProyectos.AutoScroll = true;
            flowLayoutPanelListaProyectos.Dock = DockStyle.Fill;
            flowLayoutPanelListaProyectos.Padding = new Padding(30);
            flowLayoutPanelListaProyectos.AutoScrollMargin = new Size(0, 40);
         


            labelListaProyectos.Font = new Font("Montserrat", 30, FontStyle.Bold);
            labelListaProyectos.Dock = DockStyle.Top;
            labelListaProyectos.AutoSize = false;
            labelListaProyectos.Height = 90;
            labelListaProyectos.Padding = new Padding(0, 20, 0, 0);

            buttonFiltro.BackgroundImageLayout = ImageLayout.Zoom;

            flowLayoutPanelBotonesOrdFil.Dock = DockStyle.Top;
            flowLayoutPanelBotonesOrdFil.Height = 60;
            flowLayoutPanelBotonesOrdFil.Padding = new Padding(0,0,30,10);



            foreach (var p in d.listaProyectos)
            {
                ProyectoControl tarjeta = new ProyectoControl();
                tarjeta.SetDatos(p);

                tarjeta.AgregarTareas(d.listaTareas, p);

                flowLayoutPanelListaProyectos.Controls.Add(tarjeta);
            }
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

        private void guardarDatosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            GestionDatos.GuardarDatos(d);
        }
    }
}
