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
            ConfigurarLayout();
        }

        private void ConfigurarLayout ()
        {

            var table = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 3,
                Padding = new Padding(0),
                Margin = new Padding(0)
            };

            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

            table.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 70));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10));

            table.Controls.Add(flowLayoutPanelLogo, 0, 0);
            table.SetColumnSpan(flowLayoutPanelLogo, 2);

            table.Controls.Add(flowLayoutPanelTituloDescrip, 0, 1);
            table.Controls.Add(flowLayoutPanelFechaEstado, 1, 1);

            table.Controls.Add(flowLayoutPanelButtonCrear, 0, 2);
            table.SetColumnSpan(flowLayoutPanelButtonCrear, 2);

            flowLayoutPanelLogo.Dock = DockStyle.Fill;
            flowLayoutPanelTituloDescrip.Dock = DockStyle.Fill;
            flowLayoutPanelFechaEstado.Dock = DockStyle.Fill;
            flowLayoutPanelButtonCrear.Dock = DockStyle.Fill;

            this.Controls.Add(table);
        }
    }

}
