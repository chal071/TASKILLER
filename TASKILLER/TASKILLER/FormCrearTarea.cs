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
        private Datos d;
        private Tarea tareaPadre;
        private Proyecto p;
        private Usuario u;
        public FormCrearTarea(Datos datos, Proyecto proyecto , Usuario usuario ,Tarea tareaPadre = null)
        {
            InitializeComponent();
            this.d = datos;
            this.p = proyecto;
            this.u = usuario;
            this.tareaPadre = tareaPadre;

            SetFontSize();
            ConfigurarTareaPadre();

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

        private void ConfigurarTareaPadre()
        {
            if (tareaPadre == null)
            {
                tableLayoutPanelLeftBottom.Visible = false;
                return;
            }

            tableLayoutPanelLeftBottom.Visible = true;

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

            dataGridViewTareaPadre.DataSource = new[]
            {
        new
        {
            tareaPadre.Titulo,
            tareaPadre.Estado,
            tareaPadre.Prioridad
        }
            }.ToList();

            dataGridViewTareaPadre.ReadOnly = true;
            dataGridViewTareaPadre.AllowUserToAddRows = false;
            dataGridViewTareaPadre.AllowUserToDeleteRows = false;
            dataGridViewTareaPadre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            var nueva = new Tarea
            {
                Id = Guid.NewGuid(),
                Titulo = textBoxTitulo.Text,
                Descripcion = richTextBoxDescripcion.Text,
                Prioridad = (Prioridad)comboBoxPrioridad.SelectedItem,
                Estado = (Estado)comboBoxEstado.SelectedItem,
                FechaInicio = dateTimePickerFechaInicio.Value,
                FechaFinal = dateTimePickerFechaFinal.Value,
                listaUsuarios = new List<Guid>(),
                IdProyecto = p.Id,
                Subtareas = null,
                IdTareaPadre = tareaPadre?.Id
            };

            for (int i = 0; i < checkedListBoxUsuario.Items.Count; i++)
            {
                if (checkedListBoxUsuario.GetItemChecked(i))
                {
                    string nombre = checkedListBoxUsuario.Items[i].ToString();
                    var usuario = d.listaUsuarios.FirstOrDefault(u => u.Nombre == nombre);
                    if (usuario != null)
                    {
                        nueva.listaUsuarios.Add(usuario.Id);
                    }
                }
            }

            d.listaTareas.Add(nueva);

            if (tareaPadre != null)
            {
                if (tareaPadre.Subtareas == null)
                    tareaPadre.Subtareas = new List<Guid>();

                tareaPadre.Subtareas.Add(nueva.Id);
            }

            this.DialogResult = DialogResult.OK;
            FormListaTareas f = new FormListaTareas(d,p,u);
            f.Show();
            this.Close();
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
    }





}
