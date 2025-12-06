using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASKILLER
{
    public partial class ProyectoControl : UserControl
    {
        private Datos d;
        private Proyecto p;
        private Usuario u;
        public ProyectoControl(Datos datos, Proyecto proyecto, Usuario usuario)
        {
            InitializeComponent();
            this.d = datos;
            this.p = proyecto;
            this.u = usuario;
        }
        public void AgregarTareas(List<Tarea> tareas, Proyecto p)
        {
            flowLayoutPanelListaTareas.Controls.Clear();

            foreach (var t in tareas)
            {
                if (t.IdProyecto == p.Id)
                {
                    TareaProyectoControl tareaControl = new TareaProyectoControl();
                    tareaControl.setDatos(t);
                    flowLayoutPanelListaTareas.Controls.Add(tareaControl);
                }
            }
        }


        public void SetDatos(Proyecto p)
        {
            labelNombre.Text = p.Titulo;
            labelFechas.Text = p.FechaInicio.ToString("dd/MM/yyyy") + " - " + p.FechaFinal.ToString("dd/MM/yyyy");
            labelNombre.Font = new Font(Fuentes.MontserratBold.FontFamily, 16, FontStyle.Bold);
            labelFechas.Font = new Font(Fuentes.MontserratBold.FontFamily, 15);
            labelNombre.MaximumSize = new Size(250, 150);
            buttonEditar.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            contextMenuStripEditar.Show(buttonEditar, 0, buttonEditar.Height);
        }

        private void ProyectoControl_Click(object sender, EventArgs e)
        {
            Form padre = this.FindForm();
            padre.Close();
            FormListaTareas f = new FormListaTareas(d, p, u);            
            f.Show();
        }

        private void flowLayoutPanelListaTareas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form padre = this.FindForm();
            padre.Close();
            FormEditarEliminarProyecto f = new FormEditarEliminarProyecto(d, p, u);
            f.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(
                   "¿Estás seguro de que quieres eliminar este proyecto?",
                   "Confirmar eliminación",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Warning
               );

            if (resultado == DialogResult.Yes)
            {
                d.listaProyectos.Remove(p);
                d.listaTareas.RemoveAll(t => t.IdProyecto == p.Id);
                MessageBox.Show("Proyecto eliminado correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form padre = this.FindForm();
                padre.Close();

                FormListaProyectos f = new FormListaProyectos(d, u);
                f.Show();
            }
        }
    }
}
