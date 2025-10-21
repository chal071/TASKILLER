using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASKILLER
{
    public partial class FormCrearTarea : Form
    {
        public FormCrearTarea()
        {
            InitializeComponent();
            this.Resize += Form_ReSize;
        }

        public void Form_ReSize(object sender, EventArgs e)
        {
            int totalWidth = this.ClientSize.Width;
            int totalHeight = this.ClientSize.Height;

            flowLayoutPanelLogo.Width = (int)(totalWidth - flowLayoutPanelLogo.Margin.Horizontal);
            flowLayoutPanelLogo.Height = (int)((totalHeight * 0.2) - flowLayoutPanelLogo.Margin.Vertical);

            flowLayoutPanelTituloDescrip.Width = (int)((totalWidth * 0.5) - flowLayoutPanelTituloDescrip.Margin.Horizontal);
            flowLayoutPanelTituloDescrip.Height = (int)((totalHeight * 0.7) - flowLayoutPanelTituloDescrip.Margin.Vertical);

            flowLayoutPanelFechaEstado.Width = (int)((totalWidth * 0.5) - flowLayoutPanelFechaEstado.Margin.Horizontal);
            flowLayoutPanelFechaEstado.Height = (int)((totalHeight * 0.7) - flowLayoutPanelFechaEstado.Margin.Vertical);

            flowLayoutPanelButtonCrear.Width = (int)(totalWidth - flowLayoutPanelButtonCrear.Margin.Horizontal);
            flowLayoutPanelButtonCrear.Height = (int)((totalHeight * 0.1) - flowLayoutPanelButtonCrear.Margin.Vertical);
        }
    }
}
