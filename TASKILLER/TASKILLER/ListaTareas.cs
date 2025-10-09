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
        }

        private void flowLayoutPanelListasTarea_Resize(object sender, EventArgs e)
        {
            dataGridViewListasTarea.Width = flowLayoutPanelListaTareas.ClientSize.Width - dataGridViewListasTarea.Margin.Horizontal;
        }

    }
}