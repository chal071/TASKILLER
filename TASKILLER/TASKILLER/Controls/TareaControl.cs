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
    public partial class TareaControl : UserControl
    {
        private List<Usuario> usuariosGlobal;
        private List<Tarea> tareasGlobal;
        public Tarea Tarea { get; private set; }

        public TareaControl(List<Usuario> usuarios, List<Tarea> tareasGlobal)
        {
            InitializeComponent();
            this.MouseDown += TareaControl_MouseDown;
            foreach (Control c in this.Controls)
                c.MouseDown += TareaControl_MouseDown;

            this.Dock = DockStyle.Top;
            labelNombreTarea.Font = new Font("Montserrat", 10, FontStyle.Regular);
            labelFechasTarea.Font = new Font("Montserrat", 9, FontStyle.Regular);
            labelSubtareas.Font = new Font("Montserrat", 9, FontStyle.Regular);
            dataGridViewUsuarioDeTarea.Font = new Font("Montserrat", 10, FontStyle.Regular);
            labelTareaPadre.Font = new Font("Montserrat", 9, FontStyle.Regular);
            this.usuariosGlobal = usuarios;
            this.tareasGlobal = tareasGlobal;
        }

        public void SetDatos(Tarea t)
        {
            Tarea = t;
            labelNombreTarea.Text = t.Titulo;
            labelFechasTarea.Text = $"{t.FechaInicio:dd/MM/yyyy} - {t.FechaFinal:dd/MM/yyyy}";

            int cantSubtareas = t.Subtareas != null ? t.Subtareas.Count : 0;

            if (cantSubtareas > 0)
            {
                labelSubtareas.Visible = true;
                labelSubtareas.Text = $"{cantSubtareas} subtareas en activo";
            }
            else
            {
                labelSubtareas.Visible = false;
            }

 
            var usuarios = t.listaUsuarios
                .Select(id => usuariosGlobal.FirstOrDefault(u => u.Id == id))
                .Where(u => u != null)
                .Select(u => new
                {
                    Nombre = u.Nombre
                })
                .ToList();

            dataGridViewUsuarioDeTarea.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsuarioDeTarea.RowHeadersVisible = false;
            dataGridViewUsuarioDeTarea.DataSource = usuarios;

            pictureBoxPerioridad.Visible = true;

            switch (t.Prioridad)
            {
               case Prioridad.Alta:
               pictureBoxPerioridad.Image = Properties.Resources.prioridadAlta;
               break;
               case Prioridad.Media:
               pictureBoxPerioridad.Image = Properties.Resources.prioridadMedia;
               break;
               case Prioridad.Baja:
               pictureBoxPerioridad.Image = Properties.Resources.prioridadBaja;
               break;
               default:
               pictureBoxPerioridad.Visible = false;
               break;
            }

            var idTareaPadre = t.IdTareaPadre;
            if (idTareaPadre != null)
            {
                var tareaPadre = tareasGlobal.FirstOrDefault(tarea => tarea.Id == idTareaPadre);
                if (tareaPadre != null)
                {
                    labelTareaPadre.Visible = true;
                    labelTareaPadre.Text = $"Tarea padre:\n{tareaPadre.Titulo}";
                }
                else
                {
                    labelTareaPadre.Visible = false;
                }
            }
            else
            {
                labelTareaPadre.Visible = false;
            }

        }

        private void TareaControl_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(this, DragDropEffects.Move);
        }


        public void SetBackColor(Color color)
        {
            panelEstado.BackColor = color;
        }
    }
}
