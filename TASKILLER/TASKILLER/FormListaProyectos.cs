
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

            mostrarProyectos();
        }
        private void mostrarProyectos()
        {
            var rolAdmin = d.listaRoles.FirstOrDefault(r => r.Nombre == "Administrador");
            var rolGestor = d.listaRoles.FirstOrDefault(r => r.Nombre == "Gestor");

            if (u.Rol == d.listaRoles.FirstOrDefault(r => r.Nombre == "Administrador")?.Id)
            {
                foreach (var pro in d.listaProyectos)
                {
                    ProyectoControl tarjeta = new ProyectoControl(d, pro, u);
                    tarjeta.SetDatos(pro);

                    tarjeta.AgregarTareas(d.listaTareas, pro);
                    tarjeta.Margin = new Padding(left: 25, top: 0, right: 0, bottom: 50);

                    flowLayoutPanelListaProyectos.Controls.Add(tarjeta);
                }
            }
            else if (u.Rol == d.listaRoles.FirstOrDefault(r => r.Nombre == "Gestor")?.Id)
            {
                foreach (var pro in d.listaProyectos)
                {
                    if (pro.IdCreador.Equals(u.Id))
                    {
                        ProyectoControl tarjeta = new ProyectoControl(d, pro, u);
                        tarjeta.SetDatos(pro);

                        tarjeta.AgregarTareas(d.listaTareas, pro);
                        tarjeta.Margin = new Padding(left: 25, top: 0, right: 0, bottom: 50);
                       
                        flowLayoutPanelListaProyectos.Controls.Add(tarjeta);
                    }
                   
                }
            }
            else
            {
                MessageBox.Show("No tienes permisos suficientes", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            Form padre = this.FindForm();
            padre.Close();
            FormCreacionUsuario f = new FormCreacionUsuario(d, u);
            f.Show();
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
