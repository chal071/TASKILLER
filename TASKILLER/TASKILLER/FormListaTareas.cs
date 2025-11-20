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
    public partial class FormListaTareas : Form
    {
        private Datos d;
        private ContextMenuStrip menuTarea;
        private Guid tareaSeleccionadaId;

        public FormListaTareas(Datos datos)
        {
            InitializeComponent();
            dataGridViewTareas.CellFormatting += dataGridViewTareas_CellFormatting;
            dataGridViewTareas.CellContentClick += dataGridViewTareas_CellContentClick;
            setFontSize();
            this.d = datos;
            this.p = proyecto;
            this.u = usuario;
            ConfigurarDataGridView();
            CargarTareas();
            generarMenuTarea();
            CargarPorComenzar();
            CargarEnProgreso();
            CargarEntregado();
            CargarRevisado();
            CargarBloqueado();
        }


        private void setFontSize() 
        {
            labelTarea.Font = new Font(Fuentes.MontserratBold.FontFamily, 25);
            dataGridViewTareas.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12);
            labelPorComenzar.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            labelEnProgreso.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            labelEntregado.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            labelRevisado.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            labelBloqueado.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            buttonAnadirTarea.Font = new Font(Fuentes.MontserratBold.FontFamily, 30);
        }

        public void ConfigurarDataGridView()
        {
            dataGridViewTareas.AutoGenerateColumns = false;
            dataGridViewTareas.ReadOnly = true;
            dataGridViewTareas.AllowUserToResizeColumns = false;
        }

        public void AñadirColumnaBoton()
        {
            var colBtn = new DataGridViewButtonColumn
            {
                Name = "Editar",
                HeaderText = "Editar",
                Text = "···",
                UseColumnTextForButtonValue = true
            };
            dataGridViewTareas.Columns.Add(colBtn);
        }


        public void JustificarColumnas()
        {
            dataGridViewTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTareas.Columns["ColorEstado"].FillWeight = 10;
            dataGridViewTareas.Columns["Titulo"].FillWeight = 80;
            dataGridViewTareas.Columns["Editar"].FillWeight = 10;
        }

        public void CargarTareas()
        {
            var lista = d.listaTareas
                .Select(t => new
                {
                    t.Id,
                    t.Titulo,
                    t.Estado
                })
                .ToList();

            dataGridViewTareas.Columns.Clear();
            var colEstadoTexto = new DataGridViewTextBoxColumn
            {
                Name = "Estado",
                HeaderText = "Estado",
                DataPropertyName = "Estado",
                Visible = false
            };

            dataGridViewTareas.Columns.Add(colEstadoTexto);

            var colId = new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id",
                Visible = false
            };
            dataGridViewTareas.Columns.Add(colId);

            var colEstadoColor = new DataGridViewImageColumn
            {
                Name = "ColorEstado",
                HeaderText = "Estado"
            };
            dataGridViewTareas.Columns.Add(colEstadoColor);

            var colTitulo = new DataGridViewTextBoxColumn
            {
                Name = "Titulo",
                HeaderText = "Título",
                DataPropertyName = "Titulo"
            };
            dataGridViewTareas.Columns.Add(colTitulo);

            AñadirColumnaBoton();

            dataGridViewTareas.DataSource = lista;

            JustificarColumnas();

            if (dataGridViewTareas.Columns["Estado"] != null)
            {
                dataGridViewTareas.Columns["Estado"].Visible = false;
            }
        }

        private void dataGridViewTareas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewTareas.Columns[e.ColumnIndex].Name == "ColorEstado")
            {
                var estado = dataGridViewTareas.Rows[e.RowIndex].Cells["Estado"].Value?.ToString();

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
                        color = Color.FromArgb(192, 255, 192);
                        break;
                    case "Bloqueado":
                        color = Color.FromArgb(224, 224, 224);
                        break;
                    case "Entregado":
                        color = Color.FromArgb(192, 255, 255);
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


        private void CargarPorComenzar()
        {
            flowLayoutPanelPorComenzar.Controls.Clear();


            var tareasPorComenzar = d.listaTareas
                .Where(t => t.Estado == Estado.Por_Comenzar)
                .ToList();

            foreach (var t in tareasPorComenzar)
            {
                var ctrl = new TareaControl(d.listaUsuarios);
                ctrl.SetDatos(t);
                ctrl.SetBackColor(Color.FromArgb(255, 192, 192));
                flowLayoutPanelPorComenzar.Controls.Add(ctrl);
            }
        }

        private void CargarEnProgreso()
        {
            flowLayoutPanelEnProgreso.Controls.Clear();

            var tareasEnProgreso = d.listaTareas
                .Where(t => t.Estado == Estado.En_Progreso)
                .ToList();

            foreach (var t in tareasEnProgreso)
            {
                var ctrl = new TareaControl(d.listaUsuarios);
                ctrl.SetDatos(t);
                ctrl.SetBackColor(Color.FromArgb(255, 224, 192));
                flowLayoutPanelEnProgreso.Controls.Add(ctrl);
            }
        }

        private void CargarEntregado()
        {
            flowLayoutPanelEntregado.Controls.Clear();

            var tareasEntregado = d.listaTareas
                .Where(t => t.Estado == Estado.Entregado)
                .ToList();

            foreach (var t in tareasEntregado)
            {
                var ctrl = new TareaControl(d.listaUsuarios);
                ctrl.SetDatos(t);
                ctrl.SetBackColor(Color.FromArgb(192, 255, 192));
                flowLayoutPanelEntregado.Controls.Add(ctrl);
            }
        }

        private void CargarRevisado()
        {
            flowLayoutPanelRevisado.Controls.Clear();

            var tareasRevisado = d.listaTareas
                .Where(t => t.Estado == Estado.Revisado)
                .ToList();

            foreach (var t in tareasRevisado)
            {
                var ctrl = new TareaControl(d.listaUsuarios);
                ctrl.SetDatos(t);
                ctrl.SetBackColor(Color.FromArgb(192, 255, 255));
                flowLayoutPanelRevisado.Controls.Add(ctrl);
            }
        }

        private void CargarBloqueado()
        {
            flowLayoutPanelBloqueado.Controls.Clear();

            var tareasBloqueado = d.listaTareas
                .Where(t => t.Estado == Estado.Bloqueado)
                .ToList();

            foreach (var t in tareasBloqueado)
            {
                var ctrl = new TareaControl(d.listaUsuarios);
                ctrl.SetDatos(t);
                ctrl.SetBackColor(Color.FromArgb(224, 224, 224));
                flowLayoutPanelBloqueado.Controls.Add(ctrl);
            }
        }

        private void generarMenuTarea()
        {
            menuTarea = new ContextMenuStrip();
            menuTarea.Items.Add("Modificar", null, MenuModificar_Click);
            menuTarea.Items.Add("Eliminar", null, MenuEliminar_Click);
            menuTarea.Items.Add("Crear subtarea", null, MenuCrearSubtarea_Click);
        }

        private void dataGridViewTareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridViewTareas.Columns[e.ColumnIndex].Name == "Editar")
            {
                var idObj = dataGridViewTareas.Rows[e.RowIndex].Cells["Id"].Value;
                if (idObj == null) return;

                tareaSeleccionadaId = (Guid)idObj;

                var pos = Cursor.Position;
                menuTarea.Show(pos);
            }
        }

        private void MenuModificar_Click(object sender, EventArgs e)
        {
            var tarea = d.listaTareas.FirstOrDefault(t => t.Id == tareaSeleccionadaId);
            if (tarea == null) return;

            FormEditarTarea f = new FormEditarTarea(tarea, d);
            f.Show();
            this.Hide();
            
          
        }

        private void MenuEliminar_Click(object sender, EventArgs e)
        {
            var tarea = d.listaTareas.FirstOrDefault(t => t.Id == tareaSeleccionadaId);
            if (tarea == null) return;

            var r = MessageBox.Show("¿Seguro que quieres eliminar esta tarea?",
                                    "Confirmar",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                d.listaTareas.Remove(tarea);
                CargarTareas();
                CargarBloqueado();
                CargarEnProgreso();
                CargarEntregado();
                CargarPorComenzar();
                CargarRevisado();
            }
        }

        private void MenuCrearSubtarea_Click(object sender, EventArgs e)
        {
            var tareaPadre = d.listaTareas.FirstOrDefault(t => t.Id == tareaSeleccionadaId);
            if (tareaPadre == null) return;

            FormCrearTarea f = new FormCrearTarea(d, tareaPadre);
            f.Show();
            this.Hide();
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
            FormCrearTarea f = new FormCrearTarea(d, null);
            f.Show();
            this.Hide();
        }
    }
}