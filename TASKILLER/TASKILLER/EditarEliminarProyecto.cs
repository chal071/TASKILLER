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
    public partial class EditarEliminarProyecto : Form
    {
        public EditarEliminarProyecto()
        {
            InitializeComponent();
            this.Resize += Form1_Resize;
            panelInfo.Left = (this.ClientSize.Width - panelInfo.Width) / 2;
            panelInfo.Top = (this.ClientSize.Height - panelInfo.Height) / 2;

            labelCuentanosProyecto.Font = new Font("Montserrat", 30, FontStyle.Bold);
            labelTitulo.Font = new Font("Montserrat", 15, FontStyle.Bold);
            textBoxTitulo.Font = new Font("Montserrat", 12, FontStyle.Bold);
            labelDescripcion.Font = new Font("Montserrat", 15, FontStyle.Bold);
            richTextBoxDescripcion.Font = new Font("Montserrat", 12, FontStyle.Bold);
            labelFechaInicio.Font = new Font("Montserrat", 15, FontStyle.Bold);
            dateTimePickerFechaInicio.Font = new Font("Montserrat", 12, FontStyle.Bold);
            labelFechaFinal.Font = new Font("Montserrat", 15, FontStyle.Bold);
            dateTimePickerFechaFinal.Font = new Font("Montserrat", 12, FontStyle.Bold);
            labelEstado.Font = new Font("Montserrat", 15, FontStyle.Bold);
            comboBoxEstado.Font = new Font("Montserrat", 12, FontStyle.Bold);
            buttonEliminarProyecto.Font = new Font("Montserrat", 15, FontStyle.Bold);
            buttonEditarProyecto.Font = new Font("Montserrat", 15, FontStyle.Bold);

        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            panelInfo.Left = (this.ClientSize.Width - panelInfo.Width) / 2;
            panelInfo.Top = (this.ClientSize.Height - panelInfo.Height) / 2;
        }
    }
}
