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
    public partial class FormEditarEliminarProyecto : Form
    {
        private Datos d;
        private Proyecto p;
        private Usuario u;
        public FormEditarEliminarProyecto(Datos datos, Proyecto proyecto, Usuario usuario)
        {
            InitializeComponent();
            Helpers.AplicarFuente(this, Fuentes.MontserratRegular);
            this.Resize += Form1_Resize;
            this.d = datos;
            this.p = proyecto;
            this.u = usuario;
            cargarLayout();
            cargarProyecto();
        }

        private void cargarLayout()
        {

            labelCuentanosProyecto.Font = new Font(Fuentes.MontserratBold.FontFamily, 30);
            labelTitulo.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            textBoxTitulo.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12);
            labelDescripcion.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            richTextBoxDescripcion.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12);
            labelFechaInicio.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            dateTimePickerFechaInicio.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12);
            labelFechaFinal.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            dateTimePickerFechaFinal.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12);
            labelEstado.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            comboBoxEstado.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12);
            buttonEditarProyecto.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            buttonEliminarProyecto.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            toolStripLabelNombre.Text = "Usuario: " + u.Nombre + " " + u.Apellido;
            toolStripLabelNombre.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            comboBoxEstado.DataSource = Enum.GetValues(typeof(Estado));
            panelInfo.Anchor = AnchorStyles.None;
        }
        private void cargarProyecto()
        {
            textBoxTitulo.Text = p.Titulo;
            richTextBoxDescripcion.Text = p.Descripcion;
            dateTimePickerFechaInicio.Text = p.FechaInicio.ToString();
            dateTimePickerFechaFinal.Text = p.FechaFinal.ToString();
            switch(p.Estado)
            {
                case Estado.Por_Comenzar:
                    comboBoxEstado.SelectedItem = "Por Comenzar";
                    break;
                case Estado.En_Progreso:
                    comboBoxEstado.SelectedItem = "En Progreso";
                    break;
                default:
                    comboBoxEstado.Text = p.Estado.ToString();

                    break;
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            panelInfo.Left = (this.ClientSize.Width - panelInfo.Width) / 2;
            panelInfo.Top = (this.ClientSize.Height - panelInfo.Height) / 2;
        }
        private void inicioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormInicio f = new FormInicio(d, u);
            f.Show();
            this.Close();
        }
        private void proyectosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormListaProyectos f = new FormListaProyectos(d, u);
            f.Show();
            this.Close();
        }
        private void usuariosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormListaUsuarios f = new FormListaUsuarios(d, u);
            f.Show();
            this.Close();
        }
        private void rolesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormListaRoles f = new FormListaRoles(d, u);
            f.Show();
            this.Close();
        }
        private void crearNuevoProyectoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormCrearProyecto f = new FormCrearProyecto(d, u);
            f.Show();
            this.Close();
        }
        private void crearNuevoUsuarioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Rol r = new Rol();
            r = d.listaRoles.FirstOrDefault(t => t.Nombre == "Administrador");

            if (u.Rol == r.Id)
            {
                FormCreacionUsuario f = new FormCreacionUsuario(d, u);
                f.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No tienes permisos para crear usuarios.", "Permisos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void salirToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void guardarDatosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            GestionDatos.GuardarDatos(d);
        }

        private void buttonEditarProyecto_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxTitulo.Text))
            {
                MessageBox.Show("El título es obligatorio.");
                return;
            }

            if (dateTimePickerFechaInicio.Value >= dateTimePickerFechaFinal.Value)
            {
                MessageBox.Show("La fecha de inicio debe ser anterior a la fecha final.");
                return;
            }

            if (comboBoxEstado.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un estado para el proyecto.");
                return;
            }

            d.listaProyectos.Add(p);
            p.Titulo = textBoxTitulo.Text;
            p.Descripcion = richTextBoxDescripcion.Text;
            p.FechaInicio = dateTimePickerFechaInicio.Value;
            p.FechaFinal = dateTimePickerFechaFinal.Value;
            p.Estado = (Estado)comboBoxEstado.SelectedItem;

            FormListaProyectos pr = new FormListaProyectos(d, u);
            pr.Show();
            this.Close();
            return;

        }

        private void buttonEliminarProyecto_Click(object sender, EventArgs e)
        {
            Rol r = new Rol();
            r = d.listaRoles.FirstOrDefault(t => t.Nombre == "Administrador");

            if (u.Rol == r.Id)
            {
                var resultado = MessageBox.Show(
                   "¿Estás seguro de que quieres eliminar este proyecto?",
                   "Confirmar eliminación",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Warning
               );

                if (resultado == DialogResult.Yes)
                {
                    d.listaProyectos.Remove(p);
                    d.listaTareas.RemoveAll(t => t.IdProyecto == p.Id);

                    MessageBox.Show("Proyecto eliminado correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormListaProyectos fl = new FormListaProyectos(d, u);
                    fl.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No tienes permisos para eliminar proyectos.", "Permisos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           
        }
    }
}
