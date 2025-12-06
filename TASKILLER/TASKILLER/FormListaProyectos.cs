
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TASKILLER
{
    public partial class FormListaProyectos : Form
    {
        private Datos d;
        private Usuario u;
        public FormListaProyectos(Datos datos, Usuario usuario)
        {
            InitializeComponent();
            Helpers.AplicarFuente(this, Fuentes.MontserratRegular);

            this.d = datos;
            this.u = usuario;
            cargarLayout();
        }

        private void cargarLayout()
        {
            flowLayoutPanelListaProyectos.AutoScroll = true;
            flowLayoutPanelListaProyectos.Dock = DockStyle.Fill;
            flowLayoutPanelListaProyectos.Padding = new Padding(30);
            flowLayoutPanelListaProyectos.AutoScrollMargin = new Size(0, 40);

            labelListaProyectos.Font = new Font(Fuentes.MontserratBold.FontFamily, 35, FontStyle.Bold);
            labelListaProyectos.Dock = DockStyle.Top;
            labelListaProyectos.AutoSize = false;
            labelListaProyectos.Height = 90;
            labelListaProyectos.Padding = new Padding(0, 20, 0, 0);

            flowLayoutPanelBotonesOrdFil.Dock = DockStyle.Top;
            flowLayoutPanelBotonesOrdFil.Height = 60;
            flowLayoutPanelBotonesOrdFil.Padding = new Padding(0, 0, 30, 10);

            mostrarProyectos(d, null);
            toolStripLabelNombre.Text = "Usuario: " + u.Nombre + " " + u.Apellido;

        }
        private void mostrarProyectos(Datos dat,string filtro)
        {
            flowLayoutPanelListaProyectos.Controls.Clear();

            IEnumerable<Proyecto> proyectosFiltrados = dat.listaProyectos;

            if (filtro == "Asignados")
            {
                proyectosFiltrados = dat.listaProyectos
                    .Where(p => dat.listaTareas.Any(t => t.IdProyecto == p.Id && t.listaUsuarios.Any(uT => uT == u.Id)));
            }
            else if (filtro == "Creados por mí")
            {
                proyectosFiltrados = dat.listaProyectos
                    .Where(p => p.IdCreador == u.Id);
            }
            string orden = comboBoxOrdenar.SelectedItem?.ToString() ?? "";

            switch (orden)
            {
                case "Nombre (A-Z)":
                    proyectosFiltrados = proyectosFiltrados.OrderBy(p => p.Titulo);
                    break;

                case "Nombre (Z-A)":
                    proyectosFiltrados = proyectosFiltrados.OrderByDescending(p => p.Titulo);
                    break;

                case "Más antiguos":
                    proyectosFiltrados = proyectosFiltrados.OrderBy(p => p.FechaInicio);
                    break;

                case "Más recientes":
                    proyectosFiltrados = proyectosFiltrados.OrderByDescending(p => p.FechaInicio);
                    break;

                case "Número de tareas (ascendente)":
                    proyectosFiltrados = proyectosFiltrados.OrderBy(p =>
                        dat.listaTareas.Count(t => t.IdProyecto == p.Id));
                    break;

                case "Número de tareas (descendente)":
                    proyectosFiltrados = proyectosFiltrados.OrderByDescending(p =>
                        dat.listaTareas.Count(t => t.IdProyecto == p.Id));
                    break;
            }


            foreach (var pro in proyectosFiltrados)
            {
                ProyectoControl tarjeta = new ProyectoControl(dat, pro, u);
                tarjeta.SetDatos(pro);

                tarjeta.AgregarTareas(dat.listaTareas.Where(t => t.IdProyecto == pro.Id).ToList(), pro);
                tarjeta.Margin = new Padding(left: 25, top: 0, right: 0, bottom: 50);

                flowLayoutPanelListaProyectos.Controls.Add(tarjeta);
            }

            if (!proyectosFiltrados.Any())
            {
                MessageBox.Show("No hay proyectos para mostrar con este filtro.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mostrarProyectos(d, null);
            }
        }
        private void inicioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form padre = this.FindForm();
            padre.Close();
            FormInicio f = new FormInicio(d, u);
            f.Show();
        }
        private void proyectosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form padre = this.FindForm();
            padre.Close();
            FormListaProyectos f = new FormListaProyectos(d, u);
            f.Show();
        }
        private void usuariosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form padre = this.FindForm();
            padre.Close();
            FormListaUsuarios f = new FormListaUsuarios(d, u);
            f.Show();
        }
        private void rolesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form padre = this.FindForm();
            padre.Close();
            FormListaRoles f = new FormListaRoles(d, u);
            f.Show();
        }
        private void crearNuevoProyectoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form padre = this.FindForm();
            padre.Close();
            FormCrearProyecto f = new FormCrearProyecto(d, u);
            f.Show();
        }
        private void crearNuevoUsuarioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Rol r = new Rol();
            r = d.listaRoles.FirstOrDefault(t => t.Nombre == "Administrador");

            if (u.Rol == r.Id)
            {
                Form padre = this.FindForm();
                padre.Close();
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
        private void comboBoxtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = comboBoxtipo.SelectedItem.ToString();
            mostrarProyectos(d, opcion);
        }
        private void comboBoxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarProyectos(d, comboBoxtipo.SelectedItem?.ToString());

        }
    }
}
