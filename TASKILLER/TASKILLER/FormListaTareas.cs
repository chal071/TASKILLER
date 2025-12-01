using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private Proyecto p;
        private Usuario u;

        public FormListaTareas(Datos datos, Proyecto proyecto, Usuario usuario)
        {
            InitializeComponent();
            this.d = datos;
            this.p = proyecto;
            this.u = usuario;
            dataGridViewTareas.CellFormatting += dataGridViewTareas_CellFormatting;
            dataGridViewTareas.CellContentClick += dataGridViewTareas_CellContentClick;
            setFontSize();
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
            labelTarea.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            labelTarea.Text = p.Titulo;
            dataGridViewTareas.Font = new Font(Fuentes.MontserratRegular.FontFamily, 12);
            labelPorComenzar.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            labelEnProgreso.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            labelEntregado.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            labelRevisado.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            labelBloqueado.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            buttonAnadirTarea.Font = new Font(Fuentes.MontserratBold.FontFamily, 30);
            toolStripLabelNombre.Text = "Usuario: " + u.Nombre + " " + u.Apellido;

        }

        public void ConfigurarDataGridView()
        {
            dataGridViewTareas.AutoGenerateColumns = false;
            dataGridViewTareas.ReadOnly = true;
            dataGridViewTareas.AllowUserToResizeColumns = false;
        }

        public void AñadirColumnaIcono()
        {
            var colIcon = new DataGridViewImageColumn
            {
                Name = "Editar",
                HeaderText = "Editar",
                Image = Properties.Resources.TresPuntos,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };

            dataGridViewTareas.Columns.Add(colIcon);
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
                .Where(t => t.IdProyecto == p.Id)
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

            AñadirColumnaIcono();

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


        private void CargarPorComenzar()
        {
            flowLayoutPanelPorComenzar.Controls.Clear();

            var tareasPorComenzar = d.listaTareas
                .Where(t => t.IdProyecto == p.Id && t.Estado == Estado.Por_Comenzar)
                .ToList();

            foreach (var t in tareasPorComenzar)
            {
                var ctrl = new TareaControl(d.listaUsuarios, d.listaTareas);
                ctrl.SetDatos(t);
                ctrl.SetBackColor(Color.FromArgb(255, 192, 192));
                flowLayoutPanelPorComenzar.Controls.Add(ctrl);
            }
        }


        private void CargarEnProgreso()
        {
            flowLayoutPanelEnProgreso.Controls.Clear();

            var tareasEnProgreso = d.listaTareas
                .Where(t => t.IdProyecto == p.Id && t.Estado == Estado.En_Progreso)
                .ToList();

            foreach (var t in tareasEnProgreso)
            {
                var ctrl = new TareaControl(d.listaUsuarios, d.listaTareas);
                ctrl.SetDatos(t);
                ctrl.SetBackColor(Color.FromArgb(255, 224, 192));
                flowLayoutPanelEnProgreso.Controls.Add(ctrl);
            }
        }


        private void CargarEntregado()
        {
            flowLayoutPanelEntregado.Controls.Clear();

            var tareasEntregado = d.listaTareas
                .Where(t => t.IdProyecto == p.Id && t.Estado == Estado.Entregado)
                .ToList();

            foreach (var t in tareasEntregado)
            {
                var ctrl = new TareaControl(d.listaUsuarios, d.listaTareas);
                ctrl.SetDatos(t);
                ctrl.SetBackColor(Color.FromArgb(192, 255, 192));
                flowLayoutPanelEntregado.Controls.Add(ctrl);
            }
        }



        private void CargarRevisado()
        {
            flowLayoutPanelRevisado.Controls.Clear();

            var tareasRevisado = d.listaTareas
                .Where(t => t.IdProyecto == p.Id && t.Estado == Estado.Revisado)
                .ToList();

            foreach (var t in tareasRevisado)
            {
                var ctrl = new TareaControl(d.listaUsuarios, d.listaTareas);
                ctrl.SetDatos(t);
                ctrl.SetBackColor(Color.FromArgb(192, 255, 255));
                flowLayoutPanelRevisado.Controls.Add(ctrl);
            }
        }


        private void CargarBloqueado()
        {
            flowLayoutPanelBloqueado.Controls.Clear();

            var tareasBloqueado = d.listaTareas
                .Where(t => t.IdProyecto == p.Id && t.Estado == Estado.Bloqueado)
                .ToList();

            foreach (var t in tareasBloqueado)
            {
                var ctrl = new TareaControl(d.listaUsuarios, d.listaTareas);
                ctrl.SetDatos(t);
                ctrl.SetBackColor(Color.FromArgb(224, 224, 224));
                flowLayoutPanelBloqueado.Controls.Add(ctrl);
            }
        }

        private void ConfigurarDragDrop()
        {
            ConfigurarPanelDragDrop(flowLayoutPanelPorComenzar);
            ConfigurarPanelDragDrop(flowLayoutPanelEnProgreso);
            ConfigurarPanelDragDrop(flowLayoutPanelEntregado);
            ConfigurarPanelDragDrop(flowLayoutPanelRevisado);
            ConfigurarPanelDragDrop(flowLayoutPanelBloqueado);
        }

        private void ConfigurarPanelDragDrop(FlowLayoutPanel panel)
        {
            panel.AllowDrop = true;
            panel.DragEnter += Panel_DragEnter;
            panel.DragDrop += Panel_DragDrop;
        }

        private void Panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TareaControl)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Panel_DragDrop(object sender, DragEventArgs e)
        {
            var panelDestino = (FlowLayoutPanel)sender;
            var ctrl = (TareaControl)e.Data.GetData(typeof(TareaControl));

            if (ctrl == null) return;

            if (ctrl.Parent is FlowLayoutPanel oldPanel)
                oldPanel.Controls.Remove(ctrl);

            panelDestino.Controls.Add(ctrl);

            Estado nuevoEstado;

            if (panelDestino == flowLayoutPanelPorComenzar)
                nuevoEstado = Estado.Por_Comenzar;
            else if (panelDestino == flowLayoutPanelEnProgreso)
                nuevoEstado = Estado.En_Progreso;
            else if (panelDestino == flowLayoutPanelEntregado)
                nuevoEstado = Estado.Entregado;
            else if (panelDestino == flowLayoutPanelRevisado)
                nuevoEstado = Estado.Revisado;
            else if (panelDestino == flowLayoutPanelBloqueado)
                nuevoEstado = Estado.Bloqueado;
            else
                return;

            var tarea = ctrl.Tarea;
            if (tarea != null)
                tarea.Estado = nuevoEstado;

            switch (nuevoEstado)
            {
                case Estado.Por_Comenzar:
                    ctrl.SetBackColor(Color.FromArgb(255, 192, 192));
                    break;
                case Estado.En_Progreso:
                    ctrl.SetBackColor(Color.FromArgb(255, 224, 192));
                    break;
                case Estado.Entregado:
                    ctrl.SetBackColor(Color.FromArgb(192, 255, 192));
                    break;
                case Estado.Revisado:
                    ctrl.SetBackColor(Color.FromArgb(192, 255, 255));
                    break;
                case Estado.Bloqueado:
                    ctrl.SetBackColor(Color.FromArgb(224, 224, 224));
                    break;
            }
            CargarTareas();
        }




        private void generarMenuTarea()
        {
            menuTarea = new ContextMenuStrip();
            menuTarea.Items.Add("Modificar", Properties.Resources.editar, MenuModificar_Click);
            menuTarea.Items.Add("Eliminar", Properties.Resources.borrar, MenuEliminar_Click);
            menuTarea.Items.Add("Crear subtarea", Properties.Resources.agregar, MenuCrearSubtarea_Click);
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

            FormEditarTarea f = new FormEditarTarea(tarea, d, p ,u);
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

            FormCrearTarea f = new FormCrearTarea(d, p, u, tareaPadre);
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
            FormCrearTarea f = new FormCrearTarea(d, p, u, null);
            f.Show();
            this.Hide();
        }

        private void FormListaTareas_Load(object sender, EventArgs e)
        {
            ConfigurarDragDrop();
        }
    }
}