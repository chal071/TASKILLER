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
    public partial class FormCrearProyecto : Form
    {
        private List<Proyecto> _proyectos;
        private List<Tarea> _tareas;
        private List<Usuario> _usuarios;
        private List<Rol> _roles;

        public FormCrearProyecto(List<Proyecto> proyectos, List<Tarea> tareas, List<Usuario> usuarios, List<Rol> roles)
        {
            InitializeComponent();
            _proyectos = proyectos;
            _tareas = tareas;
            _usuarios = usuarios;
            _roles = roles;
            this.Resize += Form1_Resize;
            panelInfo.Left = (this.ClientSize.Width - panelInfo.Width) / 2;
            panelInfo.Top = (this.ClientSize.Height - panelInfo.Height) / 2;

            labelCuentanosProyecto.Font = new Font(Fuentes.MontserratBold.FontFamily, 30, FontStyle.Bold);
            labelTitulo.Font = new Font(Fuentes.MontserratBold.FontFamily, 15, FontStyle.Bold);
            textBoxTitulo.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12, FontStyle.Regular);
            labelDescripcion.Font = new Font(Fuentes.MontserratBold.FontFamily, 15, FontStyle.Bold);
            richTextBoxDescripcion.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12, FontStyle.Regular);
            labelFechaInicio.Font = new Font(Fuentes.MontserratBold.FontFamily, 15, FontStyle.Bold);
            dateTimePickerFechaInicio.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12, FontStyle.Regular);
            labelFechaFinal.Font = new Font(Fuentes.MontserratBold.FontFamily, 15, FontStyle.Bold);
            dateTimePickerFechaFinal.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12, FontStyle.Regular);
            labelEstado.Font = new Font(Fuentes.MontserratBold.FontFamily, 15, FontStyle.Bold);
            comboBoxEstado.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12, FontStyle.Regular);
            buttonCrearProyecto.Font = new Font(Fuentes.MontserratBold.FontFamily, 15, FontStyle.Bold);

            comboBoxEstado.DataSource = Enum.GetValues(typeof(Estado));

        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            panelInfo.Left = (this.ClientSize.Width - panelInfo.Width) / 2;
            panelInfo.Top = (this.ClientSize.Height - panelInfo.Height) / 2;
        }

        private void buttonCrearProyecto_Click(object sender, EventArgs e)
        {
            GestionDatos.GuardarDatos(_proyectos, _tareas, _usuarios, _roles);
            MessageBox.Show("Datos guardados y cifrados correctamente!");
        }
    }
}
