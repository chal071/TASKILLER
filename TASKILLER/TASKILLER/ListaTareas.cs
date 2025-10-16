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
    public partial class ListaTareas : Form
    {
        public ListaTareas()
        {
            InitializeComponent();
            AplicarFontALabels();
            this.Resize += FlowLayoutPanels_Resize;
        }

        private void FlowLayoutPanels_Resize(object sender, EventArgs e)
        {
            int totalWidth = this.ClientSize.Width;
            int totalHeight = this.ClientSize.Height;

            flowLayoutPanelListaTareas.Width = (int)(totalWidth * 0.25);
            flowLayoutPanelListaTareas.Height = totalHeight;

            flowLayoutPanelListaEstadoTareas.Width = (int)(totalWidth * 0.75);
            flowLayoutPanelListaEstadoTareas.Height = totalHeight;

            flowLayoutPanelListaEstadoTareas.Left = flowLayoutPanelListaTareas.Right;

            dataGridViewListasTarea.Width = flowLayoutPanelListaTareas.ClientSize.Width - dataGridViewListasTarea.Margin.Horizontal;

            labelNombreProyecto.Width = flowLayoutPanelListaEstadoTareas.ClientSize.Width - labelNombreProyecto.Margin.Horizontal;
            labelNombreProyecto.Height = (int)(flowLayoutPanelListaEstadoTareas.ClientSize.Height * 0.1) - labelNombreProyecto.Margin.Vertical;
            int ancho = flowLayoutPanelListaEstadoTareas.ClientSize.Width / 5;
            int alto = flowLayoutPanelListaEstadoTareas.ClientSize.Height - labelNombreProyecto.ClientSize.Height;

            AjustarGroupBox(groupBoxTareasPorComenzar, ancho, alto);
            AjustarGroupBox(groupBoxEnProgreso, ancho, alto);
            AjustarGroupBox(groupBoxEntregado, ancho, alto);
            AjustarGroupBox(groupBoxRevisado, ancho, alto);
            AjustarGroupBox(groupBoxBloqueado, ancho, alto);
        }

        private void AjustarGroupBox(GroupBox g, int ancho, int alto)
        {
            g.Width = ancho - g.Margin.Horizontal;
            g.Height = alto - g.Margin.Vertical;
        }


        private void AplicarFontALabels() 
        {
            labelTareas.Font = new Font("Montserrat", 18, FontStyle.Regular);
            labelNombreProyecto.Font = new Font("Montserrat", 25, FontStyle.Regular);
            dataGridViewListasTarea.Font = new Font("Montserrat", 12, FontStyle.Regular);
            groupBoxTareasPorComenzar.Font = new Font("Montserrat", 14, FontStyle.Regular);
            groupBoxEnProgreso.Font = new Font("Montserrat", 14, FontStyle.Regular);
            groupBoxEntregado.Font = new Font("Montserrat", 14, FontStyle.Regular);
            groupBoxRevisado.Font = new Font("Montserrat", 14, FontStyle.Regular);
            groupBoxBloqueado.Font = new Font("Montserrat", 14, FontStyle.Regular);
        }
    }
}