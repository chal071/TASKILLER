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
        private Proyecto p;
        private Usuario u;
        public FormCrearTarea(Datos datos, Proyecto proyecto, Usuario usuario)
        {
            InitializeComponent();
            this.d = datos;
            this.p = proyecto;
            this.u = usuario;
            SetFontSize();
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

            checkedListBoxUsuario.Items.Clear();
            foreach (Usuario usuario in d.listaUsuarios)
            {
                checkedListBoxUsuario.Items.Add(usuario.Nombre);
            }
            comboBoxPrioridad.DataSource = Enum.GetValues(typeof(Prioridad));
            comboBoxEstado.DataSource = Enum.GetValues(typeof(Estado));

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

        private void modificarEliminarProyectoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormEditarEliminarProyecto f = new FormEditarEliminarProyecto(d, p, u);
            f.Show();
            this.Hide();
        }
        private void salirToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }



   

}
