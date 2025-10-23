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
            buttonCrearProyecto.Font = new Font("Montserrat", 15, FontStyle.Bold);

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
