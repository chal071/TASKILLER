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
            CargarTareaPadreYSubtareas();
            ConfigurarGrids();
            dataGridViewSubtarea.CellFormatting += dataGridViewSubtarea_CellFormatting;

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
            toolStripLabelNombre.Text = "Usuario: " + u.Nombre + " " + u.Apellido;
            toolStripDropDownButton1.Font = new Font(Fuentes.MontserratBold.FontFamily, 12);
            labelHoraDedicada.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            numericUpDownHoras.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12);
            labelH.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            labelM.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            numericUpDownMinutos.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12);
            buttonCancelar.Font = new Font(Fuentes.MontserratBold.FontFamily, 20);

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

            int total = t.DuracionMinutos;
            int horas = total / 60;
            int minutos = total % 60;

            numericUpDownHoras.Value = horas;
            numericUpDownMinutos.Value = minutos;


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
                DataPropertyName = "Estado",
                Visible = false
            });

            dataGridViewSubtarea.Columns.Add(new DataGridViewImageColumn
            {
                Name = "ColorEstado",
                HeaderText = "Estado"
            });
            


            dataGridViewSubtarea.DataSource = subtareas
                .Select(x => new
                {
                    x.Titulo,
                    x.Estado,
                })
                .ToList();

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
                }
            }.ToList();
                }
            }
            else
            {
                dataGridViewTareaPadre.DataSource = null;
            }


        }

        private void dataGridViewSubtarea_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewSubtarea.Columns[e.ColumnIndex].Name == "ColorEstado")
            {
                var estado = dataGridViewSubtarea.Rows[e.RowIndex].Cells["Estado"].Value?.ToString();

                Color color = Color.Transparent;

                switch (estado)
                {
                    case "Por_Comenzar":
                        color = Color.FromArgb(255, 192, 192);
                        break;
                    case "En_Progreso":
                        color = Color.FromArgb(255, 224, 192);
                        break;
                    case "Revisado":
                        color = Color.FromArgb(192, 255, 255);
                        break;
                    case "Bloqueado":
                        color = Color.FromArgb(224, 224, 224);
                        break;
                    case "Entregado":
                        color = Color.FromArgb(192, 255, 192);
                        break;
                }

                Bitmap bmp = new Bitmap(16, 16);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(color);
                }

                e.Value = bmp;
            }
        }


        private void buttonCrear_Click(object sender, EventArgs e)
        {

        }

        private void ConfigurarGrids()
        {
            dataGridViewSubtarea.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSubtarea.RowHeadersVisible = false;
            dataGridViewSubtarea.AllowUserToAddRows = false;
            dataGridViewSubtarea.AllowUserToDeleteRows = false;
            dataGridViewSubtarea.ReadOnly = true;
            dataGridViewSubtarea.Columns["ColorEstado"].FillWeight = 10;
            dataGridViewSubtarea.Columns["Titulo"].FillWeight = 90;

            dataGridViewTareaPadre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTareaPadre.RowHeadersVisible = false;
            dataGridViewTareaPadre.AllowUserToAddRows = false;
            dataGridViewTareaPadre.AllowUserToDeleteRows = false;
            dataGridViewTareaPadre.ReadOnly = true;

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

        private void buttonAnadirTarea_Click(object sender, EventArgs e)
        {
            FormCrearTarea f = new FormCrearTarea(d, p, u, null);
            f.Show();
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FormListaTareas f = new FormListaTareas(d, p, u);
            f.Show();
            this.Close();
        }
    }


}
