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
        public FormListaTareas(Datos datos)
        {
            InitializeComponent();
            setFontSize();
            this.d = datos;
            ConfigurarDataGridView();
            CargarTareas();
            CargarPorComenzar();
            CargarEnProgreso();
            CargarEntregado();
            CargarRevisado();
            CargarBloqueado();
        }


        private void setFontSize() 
        {
            labelTarea.Font = new Font(Fuentes.MontserratBold.FontFamily, 30);
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
            dataGridViewTareas.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            dataGridViewTareas.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewTareas.AutoGenerateColumns = true;
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
            dataGridViewTareas.Columns["Titulo"].FillWeight = 60;
            dataGridViewTareas.Columns["Estado"].FillWeight = 30;
            dataGridViewTareas.Columns["Editar"].FillWeight = 10;
        }

        public void CargarTareas()
        {

            var lista = d.listaTareas.Select(t => new {
                t.Titulo,
                t.Estado,
            }).ToList();


            dataGridViewTareas.DataSource = lista;

            AñadirColumnaBoton();
            JustificarColumnas();
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
                flowLayoutPanelBloqueado.Controls.Add(ctrl);
            }
        }

        private void inicioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormInicio f = new FormInicio(d);
            f.Show();
            this.Hide();
        }

        private void proyectosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormListaProyectos f = new FormListaProyectos(d);
            f.Show();
            this.Hide();
        }

        private void usuariosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormListaUsuarios f = new FormListaUsuarios(d);
            f.Show();
            this.Hide();
        }

        private void rolesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormListaRoles f = new FormListaRoles(d);
            f.Show();
            this.Hide();
        }

        private void crearNuevoProyectoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormCrearProyecto f = new FormCrearProyecto(d);
            f.Show();
            this.Hide();
        }
        private void crearNuevoUsuarioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormCreacionUsuario f = new FormCreacionUsuario(d);
            f.Show();
            this.Hide();
        }

        private void modificarEliminarProyectoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormEditarEliminarProyecto f = new FormEditarEliminarProyecto(d);
            f.Show();
            this.Hide();
        }
        private void salirToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void inicioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormInicio f = new FormInicio(d);
            f.Show();
            this.Hide();
        }

        private void proyectosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormListaProyectos f = new FormListaProyectos(d);
            f.Show();
            this.Hide();
        }

        private void usuariosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormListaUsuarios f = new FormListaUsuarios(d);
            f.Show();
            this.Hide();
        }

        private void rolesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormListaRoles f = new FormListaRoles(d);
            f.Show();
            this.Hide();
        }

        private void crearNuevoProyectoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormCrearProyecto f = new FormCrearProyecto(d);
            f.Show();
            this.Hide();
        }
        private void crearNuevoUsuarioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormCreacionUsuario f = new FormCreacionUsuario(d);
            f.Show();
            this.Hide();
        }

        private void modificarEliminarProyectoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormEditarEliminarProyecto f = new FormEditarEliminarProyecto(d);
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