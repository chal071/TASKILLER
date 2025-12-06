using System;
using System.Drawing;
using System.Windows.Forms;

namespace TASKILLER
{
    public partial class FormInicio : Form
    {
        private Datos d;
        private Usuario u;
        public FormInicio(Datos datos, Usuario usuario)
        {
            InitializeComponent();
            this.d = datos;
            this.u = usuario;
            Helpers.AplicarFuente(this, Fuentes.MontserratRegular);
            this.Resize += Form_Resize;
            setFontSize();
            toolStripLabelNombre.Text = "Usuario: " + u.Nombre + " " + u.Apellido;
            flowLayoutPanelHoy.AutoScroll = true;
            flowLayoutPanelHoy.Dock = DockStyle.None;
            flowLayoutPanelHoy.AutoScrollMargin = new Size(0, 30);

            foreach (var pr in d.listaProyectos)
            {
                if (pr.FechaFinal.Date == DateTime.Now.Date)
                {
                    ProyectoControlInicio tarjeta = new ProyectoControlInicio(d, pr, u);
                    tarjeta.SetDatos(pr);

                    tarjeta.Margin = new Padding(10);
                    flowLayoutPanelHoy.Controls.Add(tarjeta);
                }
            }

            flowLayoutPanelSemana.AutoScroll = true;
            flowLayoutPanelSemana.Dock = DockStyle.None;
            flowLayoutPanelSemana.AutoScrollMargin = new Size(0, 30);

            foreach (var pr in d.listaProyectos)
            {
                if (pr.FechaFinal.Date <= DateTime.Now.Date.AddDays(7))
                {
                    ProyectoControlInicio tarjeta = new ProyectoControlInicio(d, pr, u);
                    tarjeta.SetDatos(pr);

                    tarjeta.Margin = new Padding(10);
                    flowLayoutPanelSemana.Controls.Add(tarjeta);
                }
            }
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
            FormInicio f = new FormInicio(d, u);
            f.Show();
            this.Hide();
        }

        private void proyectosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormListaProyectos f = new FormListaProyectos(d, u);
            f.Show();
            this.Hide();
        }

        private void usuariosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormListaUsuarios f = new FormListaUsuarios(d, u);
            f.Show();
            this.Hide();
        }

        private void rolesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormListaRoles f = new FormListaRoles(d, u);
            f.Show();
            this.Hide();
        }

        private void crearNuevoProyectoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormCrearProyecto f = new FormCrearProyecto(d, u);
            f.Show();
            this.Hide();
        }
        private void crearNuevoUsuarioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormCreacionUsuario f = new FormCreacionUsuario(d, u);
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
