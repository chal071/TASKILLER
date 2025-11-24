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
    public partial class FormEditarTarea : Form
    {
        private Datos d;
        private Tarea t;
        private Usuario u;
        private Proyecto p;

        public FormEditarTarea(Tarea t, Datos datos, Proyecto p, Usuario u)
        {
            InitializeComponent();

            this.d = datos;
            this.t = t;
            this.u = u;
            this.p = p;

            SetFontSize();
            CargarDatosDeTarea();
            ConfigurarGrids();
            CargarTareaPadreYSubtareas();
            buttonCrear.Click += buttonCrear_Click;
            
        }

        public void SetFontSize()
        {
            labelCuentanos.Font = new Font(Fuentes.MontserratBold.FontFamily, 30);
            labelTitulo.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            textBoxTitulo.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12);
            labelDescripcion.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            richTextBoxDescripcion.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12);
            labelPrioridad.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            comboBoxPrioridad.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12);
            labelFechaInicio.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            dateTimePickerFechaInicio.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12);
            labelFechaFinal.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            dateTimePickerFechaFinal.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12);
            labelEstado.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            comboBoxEstado.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12);
            labelUsuarioAsignado.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            checkedListBoxUsuario.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12);
            buttonCrear.Font = new Font(Fuentes.MontserratBold.FontFamily, 20);
            labelSubtarea.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            dataGridViewSubtarea.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12);
            labelTareaPadre.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            dataGridViewTareaPadre.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12);

            checkedListBoxUsuario.Items.Clear();
            foreach (Usuario usuario in d.listaUsuarios)
            {
                checkedListBoxUsuario.Items.Add(usuario.Nombre);
            }
            comboBoxPrioridad.DataSource = Enum.GetValues(typeof(Prioridad));
            comboBoxEstado.DataSource = Enum.GetValues(typeof(Estado));
        }

        private void CargarDatosDeTarea()
        {
            textBoxTitulo.Text = t.Titulo;
            richTextBoxDescripcion.Text = t.Descripcion ?? "";

            dateTimePickerFechaInicio.Value = t.FechaInicio;
            dateTimePickerFechaFinal.Value = t.FechaFinal;

            comboBoxPrioridad.SelectedItem = t.Prioridad;
            comboBoxEstado.SelectedItem = t.Estado;

            for (int i = 0; i < checkedListBoxUsuario.Items.Count; i++)
            {
                string nombre = checkedListBoxUsuario.Items[i].ToString();
                var usuario = d.listaUsuarios.FirstOrDefault(u => u.Nombre == nombre);
                if (usuario != null && t.listaUsuarios.Contains(usuario.Id))
                {
                    checkedListBoxUsuario.SetItemChecked(i, true);
                }
            }
        }

        private void CargarTareaPadreYSubtareas()
        {

            var subtareas = d.listaTareas
                .Where(x => x.IdTareaPadre == t.Id)
                .ToList();

            dataGridViewSubtarea.AutoGenerateColumns = false;
            dataGridViewSubtarea.Columns.Clear();


            dataGridViewSubtarea.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Titulo",
                HeaderText = "Título",
                DataPropertyName = "Titulo"
            });


            dataGridViewSubtarea.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estado",
                HeaderText = "Estado",
                DataPropertyName = "Estado"
            });


            dataGridViewSubtarea.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Prioridad",
                HeaderText = "Prioridad",
                DataPropertyName = "Prioridad"
            });

            dataGridViewSubtarea.DataSource = subtareas
                .Select(x => new
                {
                    x.Titulo,
                    x.Estado,
                    x.Prioridad
                })
                .ToList();

            dataGridViewSubtarea.ReadOnly = true;
            dataGridViewSubtarea.AllowUserToAddRows = false;
            dataGridViewSubtarea.AllowUserToDeleteRows = false;


            dataGridViewTareaPadre.AutoGenerateColumns = false;
            dataGridViewTareaPadre.Columns.Clear();

            dataGridViewTareaPadre.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Titulo",
                HeaderText = "Título",
                DataPropertyName = "Titulo"
            });

            dataGridViewTareaPadre.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estado",
                HeaderText = "Estado",
                DataPropertyName = "Estado"
            });

            dataGridViewTareaPadre.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Prioridad",
                HeaderText = "Prioridad",
                DataPropertyName = "Prioridad"
            });

            if (t.IdTareaPadre != null)
            {
                var padre = d.listaTareas.FirstOrDefault(x => x.Id == t.IdTareaPadre);

                if (padre != null)
                {
                    dataGridViewTareaPadre.DataSource = new[]
                    {
                new
                {
                    padre.Titulo,
                    padre.Estado,
                    padre.Prioridad
                }
            }.ToList();
                }
            }
            else
            {
                dataGridViewTareaPadre.DataSource = null;
            }

            dataGridViewTareaPadre.ReadOnly = true;
            dataGridViewTareaPadre.AllowUserToAddRows = false;
            dataGridViewTareaPadre.AllowUserToDeleteRows = false;
        }


        private void buttonCrear_Click(object sender, EventArgs e)
        {
            t.Titulo = textBoxTitulo.Text;
            t.Descripcion = richTextBoxDescripcion.Text;
            t.Prioridad = (Prioridad)comboBoxPrioridad.SelectedItem;
            t.Estado = (Estado)comboBoxEstado.SelectedItem;
            t.FechaInicio = dateTimePickerFechaInicio.Value;
            t.FechaFinal = dateTimePickerFechaFinal.Value;

            var nuevosUsuarios = new List<Guid>();
            for (int i = 0; i < checkedListBoxUsuario.Items.Count; i++)
            {
                if (checkedListBoxUsuario.GetItemChecked(i))
                {
                    string nombre = checkedListBoxUsuario.Items[i].ToString();
                    var usuario = d.listaUsuarios.FirstOrDefault(u => u.Nombre == nombre);
                    if (usuario != null)
                        nuevosUsuarios.Add(usuario.Id);
                }
            }
            t.listaUsuarios = nuevosUsuarios;

            this.DialogResult = DialogResult.OK;
            FormListaTareas f = new FormListaTareas(d, p, u);
            f.Show();
            this.Close();
        }

        private void ConfigurarGrids()
        {
            dataGridViewSubtarea.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSubtarea.RowHeadersVisible = false;
            dataGridViewSubtarea.AllowUserToAddRows = false;
            dataGridViewSubtarea.AllowUserToDeleteRows = false;


            dataGridViewTareaPadre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTareaPadre.RowHeadersVisible = false;
            dataGridViewTareaPadre.AllowUserToAddRows = false;
            dataGridViewTareaPadre.AllowUserToDeleteRows = false;

        }


        private void inicioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormInicio f = new FormInicio(d, u);
            f.Show();
            this.Hide();
        }

        private void proyectosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormListaProyectos f = new FormListaProyectos(d, u);
            f.Show();
            this.Hide();
        }

        private void usuariosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormListaUsuarios f = new FormListaUsuarios(d, u);
            f.Show();
            this.Hide();
        }

        private void rolesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormListaRoles f = new FormListaRoles(d, u);
            f.Show();
            this.Hide();
        }

        private void crearNuevoProyectoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormCrearProyecto f = new FormCrearProyecto(d, u);
            f.Show();
            this.Hide();
        }
        private void crearNuevoUsuarioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormCreacionUsuario f = new FormCreacionUsuario(d, u);
            f.Show();
            this.Hide();
        }
        private void salirToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void guardarDatosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            GestionDatos.GuardarDatos(d);
        }

        private void buttonAnadirTarea_Click(object sender, EventArgs e)
        {
            FormCrearTarea f = new FormCrearTarea(d, p, u, null);
            f.Show();
            this.Hide();
        }
    }


}
