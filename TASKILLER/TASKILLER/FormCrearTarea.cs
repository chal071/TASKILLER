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
            toolStripLabelNombre.Text = "Usuario: " + u.Nombre + " " + u.Apellido;
            toolStripDropDownButton1.Font = new Font(Fuentes.MontserratBold.FontFamily, 12);
            labelHoraDedicada.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            numericUpDownH.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12);
            numericUpDownM.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12);
            labelH.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            labelM.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            buttonCancelar.Font = new Font(Fuentes.MontserratBold.FontFamily, 20);


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
            string mensajeError;
            bool valido = ValidarNuevaTarea(out mensajeError);

            if (valido)
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
                    IdTareaPadre = tareaPadre?.Id,
                    DuracionMinutos = (int)(numericUpDownH.Value * 60 + numericUpDownM.Value)
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

                            if (!p.listaUsuarios.Contains(usuario.Id))
                            {
                                p.listaUsuarios.Add(usuario.Id);
                            }
                        }
                    }
                }

                d.listaTareas.Add(nueva);

                if (tareaPadre != null)
                {
                    if (tareaPadre.Subtareas == null)
                    {
                        tareaPadre.Subtareas = new List<Guid>();
                    }

                    tareaPadre.Subtareas.Add(nueva.Id);
                }

                this.DialogResult = DialogResult.OK;
                FormListaTareas f = new FormListaTareas(d, p, u);
                f.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "No se puede crear la tarea:\n\n" + mensajeError,
                    "Datos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }


        private bool ValidarNuevaTarea(out string mensaje)
        {
            bool valido = true;
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrWhiteSpace(textBoxTitulo.Text))
            {
                valido = false;
                sb.AppendLine("• El título es obligatorio.");
            }

            if (comboBoxPrioridad.SelectedItem == null)
            {
                valido = false;
                sb.AppendLine("• Debes seleccionar una prioridad.");
            }

            if (comboBoxEstado.SelectedItem == null)
            {
                valido = false;
                sb.AppendLine("• Debes seleccionar un estado.");
            }

            DateTime inicio = dateTimePickerFechaInicio.Value;
            DateTime fin = dateTimePickerFechaFinal.Value;

            if (fin < inicio)
            {
                valido = false;
                sb.AppendLine("• La fecha final no puede ser anterior a la fecha de inicio.");
            }

            int duracion = (int)(numericUpDownH.Value * 60 + numericUpDownM.Value);
            if (duracion <= 0)
            {
                valido = false;
                sb.AppendLine("• La duración debe ser mayor que 0.");
            }

            bool hayUsuario = false;
            for (int i = 0; i < checkedListBoxUsuario.Items.Count; i++)
            {
                if (checkedListBoxUsuario.GetItemChecked(i))
                {
                    hayUsuario = true;
                }
            }

            if (hayUsuario == false)
            {
                valido = false;
                sb.AppendLine("• Debes asignar al menos un usuario.");
            }

            if (tareaPadre != null)
            {
                if (inicio < tareaPadre.FechaInicio || fin > tareaPadre.FechaFinal)
                {
                    valido = false;
                    sb.AppendLine("• Las fechas deben estar dentro del rango de la tarea padre.");
                }
            }

            mensaje = sb.ToString().Trim();
            return valido;
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FormListaTareas f = new FormListaTareas(d, p, u);
            f.Show();
            this.Close();
        }
    }





}
