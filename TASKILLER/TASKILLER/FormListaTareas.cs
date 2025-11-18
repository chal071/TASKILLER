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
        private Proyecto p;
        private Usuario u;
        public FormListaTareas(Datos datos, Proyecto proyecto, Usuario usuario)
        {
            InitializeComponent();
            setFontSize();
            this.d = datos;
            this.p = proyecto;
            this.u = usuario;
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