
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TASKILLER
{
    public partial class ListaProyectos : Form
    {
        public ListaProyectos()
        {
            InitializeComponent();

            labelListaProyectos.Font = new Font("Montserrat", 30, FontStyle.Bold);
            labelListaProyectos.Dock = DockStyle.Top;
            labelListaProyectos.AutoSize = false;
            labelListaProyectos.Height = 90;
            labelListaProyectos.Padding = new Padding(0, 20, 0, 0);

            flowLayoutPanelBotonesOrdFil.Dock = DockStyle.Top;  // on tens els botons
            flowLayoutPanelBotonesOrdFil.Height = 60;
            flowLayoutPanelBotonesOrdFil.Padding = new Padding(0,0,30,0);
            flowLayoutPanelBotonesOrdFil.Margin = new Padding(0, 0, 0, 50);

            flowLayoutPanelListaProyectos.Dock = DockStyle.Fill;
            flowLayoutPanelListaProyectos.Padding = new Padding(20); // menos padding
            flowLayoutPanelListaProyectos.WrapContents = true;
            flowLayoutPanelListaProyectos.AutoScroll = true;
            flowLayoutPanelListaProyectos.Margin = new Padding(0, 0, 0, 30);

            buttonFiltro.BackgroundImageLayout = ImageLayout.Zoom;

            List<Proyecto> ListProyectos = new List<Proyecto>();

            ListProyectos.Add(new Proyecto("Desarrollo App Móvil", 2025, 2026));
            ListProyectos.Add(new Proyecto("Página Web Corporativa", 2024, 2025));
            ListProyectos.Add(new Proyecto("Migración a la Nube", 2023, 2024));
            ListProyectos.Add(new Proyecto("Implementación ERP", 2025, 2027));
            ListProyectos.Add(new Proyecto("Desarrollo App Móvil", 2025, 2026));
            ListProyectos.Add(new Proyecto("Página Web Corporativa", 2024, 2025));
            ListProyectos.Add(new Proyecto("Migración a la Nube", 2023, 2024));
            ListProyectos.Add(new Proyecto("Implementación ERP", 2025, 2027));
            ListProyectos.Add(new Proyecto("Desarrollo App Móvil", 2025, 2026));
            ListProyectos.Add(new Proyecto("Página Web Corporativa", 2024, 2025));
            ListProyectos.Add(new Proyecto("Migración a la Nube", 2023, 2024));
            ListProyectos.Add(new Proyecto("Implementación ERP", 2025, 2027));
            ListProyectos.Add(new Proyecto("Implementación ERP", 2025, 2027));

            foreach (var p in ListProyectos)
            {
                ProyectoControl tarjeta = new ProyectoControl();
                tarjeta.SetDatos(p);
                tarjeta.Margin = new Padding(20);
                flowLayoutPanelListaProyectos.Controls.Add(tarjeta);
            }

        }

        private void comboBoxOrdenar_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void flowLayoutPanelBotonesOrdFil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanelListaProyectos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
