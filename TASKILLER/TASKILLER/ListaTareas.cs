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
            flowLayoutPanelListaTareas.Resize += flowLayoutPanelListasTarea_Resize;
            flowLayoutPanelListaEstadoTareas.Resize += flowLayoutPanelListaEstadoTareas_Resize;
        }

        private void flowLayoutPanelListasTarea_Resize(object sender, EventArgs e)
        {
            dataGridViewListasTarea.Width = flowLayoutPanelListaTareas.ClientSize.Width - dataGridViewListasTarea.Margin.Horizontal;
        }

        private void flowLayoutPanelListaEstadoTareas_Resize(object sender, EventArgs e)
        {
            groupBoxTareasPorComenzar.Width = (flowLayoutPanelListaEstadoTareas.ClientSize.Width/4) - groupBoxTareasPorComenzar.Margin.Horizontal;
            groupBoxTareasPorComenzar.Height = flowLayoutPanelListaEstadoTareas.ClientSize.Height - groupBoxTareasPorComenzar.Margin.Vertical;
            groupBoxEnProgreso.Width = (flowLayoutPanelListaEstadoTareas.ClientSize.Width/4) - groupBoxEnProgreso.Margin.Horizontal;
            groupBoxEnProgreso.Height = flowLayoutPanelListaEstadoTareas.ClientSize.Height - groupBoxEnProgreso.Margin.Vertical;
            groupBoxEntregado.Width = (flowLayoutPanelListaEstadoTareas.ClientSize.Width/4) - groupBoxEntregado.Margin.Horizontal;
            groupBoxEntregado.Height = flowLayoutPanelListaEstadoTareas.ClientSize.Height - groupBoxEntregado.Margin.Vertical;
            groupBoxRevisado.Width = (flowLayoutPanelListaEstadoTareas.ClientSize.Width/4) - groupBoxRevisado.Margin.Horizontal;
            groupBoxRevisado.Height = flowLayoutPanelListaEstadoTareas.ClientSize.Height - groupBoxRevisado.Margin.Vertical;
        }



    }
}