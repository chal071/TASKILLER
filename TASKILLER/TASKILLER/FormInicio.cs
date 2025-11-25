using System;
using System.Drawing;
using System.Windows.Forms;

namespace TASKILLER
{
    public partial class FormInicio : Form
    {
        private Datos d;
        private Usuario u;
        public FormInicio(Datos datos, Usuario u)
        {
            InitializeComponent();
            this.d = datos;
            this.u = u;
            Helpers.AplicarFuente(this, Fuentes.MontserratRegular);
            this.Resize += Form_Resize;
            setFontSize();
            flowLayoutPanelHoy.AutoScroll = true;
            flowLayoutPanelHoy.Dock = DockStyle.None;
            flowLayoutPanelHoy.Padding = new Padding(20);
            flowLayoutPanelHoy.AutoScrollMargin = new Size(0, 30);

            foreach (var p in d.listaProyectos)
            {
                if (p.FechaFinal.Date == DateTime.Now.Date)
                    continue;
                ProyectoControlInicio tarjeta = new ProyectoControlInicio(d);
                tarjeta.SetDatos(p);

                tarjeta.Margin = new Padding(10);
                flowLayoutPanelHoy.Controls.Add(tarjeta);
            }

            flowLayoutPanelSemana.AutoScroll = true;
            flowLayoutPanelSemana.Dock = DockStyle.None;
            flowLayoutPanelSemana.Padding = new Padding(20);
            flowLayoutPanelSemana.AutoScrollMargin = new Size(0, 30);

            foreach (var p in d.listaProyectos)
            {
                ProyectoControlInicio tarjeta = new ProyectoControlInicio(d);
                tarjeta.SetDatos(p);

                tarjeta.Margin = new Padding(10);
                flowLayoutPanelSemana.Controls.Add(tarjeta);
            }

            this.u = u;
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
