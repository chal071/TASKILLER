using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TASKILLER
{
    public partial class FormCrearProyecto : Form
    {
        private Datos d;
        private Usuario u;
        public FormCrearProyecto(Datos datos, Usuario usuario)
        {
            InitializeComponent();
            Helpers.AplicarFuente(this, Fuentes.MontserratRegular);

            this.Resize += Form1_Resize;
            this.d = datos;
            this.u = usuario;

            cargarLayout();
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
            buttonCrearProyecto.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            var estados = new List<object>
            {
                new { Texto = "Por Comenzar", Valor = Estado.Por_Comenzar },
                new { Texto = "En Progreso", Valor = Estado.En_Progreso },
                new { Texto = "Entregado", Valor = Estado.Entregado },
                new { Texto = "Revisado", Valor = Estado.Revisado },
                new { Texto = "Bloqueado", Valor = Estado.Bloqueado },
            };

            comboBoxEstado.DataSource = estados;
            comboBoxEstado.DisplayMember = "Texto";
            comboBoxEstado.ValueMember = "Valor";


            toolStripLabelNombre.Text = "Usuario: " + u.Nombre + " " + u.Apellido;
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
        private void guardarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionDatos.GuardarDatos(d);
        }
        private void salirToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void buttonCrearProyecto_Click(object sender, EventArgs e)
        {
            Proyecto p = new Proyecto
            {
                Id = Guid.NewGuid(),
                Titulo = textBoxTitulo.Text,
                Descripcion = richTextBoxDescripcion.Text,
                FechaInicio = dateTimePickerFechaInicio.Value,
                FechaFinal = dateTimePickerFechaFinal.Value,
                IdCreador = u.Id,
                Estado = (Estado)comboBoxEstado.SelectedValue,
                listaUsuarios = new List<Guid>()
            };

            if (string.IsNullOrEmpty(p.Titulo))
            {
                MessageBox.Show("Título y descripción son obligatorios.");
                return;
            }

            if (p.FechaInicio >= p.FechaFinal)
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
            FormListaProyectos f = new FormListaProyectos(d, u);
            f.Show();
            this.Close();
        }
    }
}
