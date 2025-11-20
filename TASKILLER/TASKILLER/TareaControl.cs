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
        public TareaControl(List<Usuario> usuarios)
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            labelNombreTarea.Font = new Font("Montserrat", 10, FontStyle.Regular);
            labelFechasTarea.Font = new Font("Montserrat", 9, FontStyle.Regular);
            labelSubtareas.Font = new Font("Montserrat", 9, FontStyle.Regular);
            dataGridViewUsuarioDeTarea.Font = new Font("Montserrat", 10, FontStyle.Regular);
            usuariosGlobal = usuarios;
        }

        public void SetDatos(Tarea t)
        {
            labelNombreTarea.Text = t.Titulo;
            labelFechasTarea.Text = $"{t.FechaInicio:dd/MM/yyyy} - {t.FechaFinal:dd/MM/yyyy}";

            int cantSubtareas = t.Subtareas != null ? t.Subtareas.Count : 0;

            if (cantSubtareas > 0)
            {
                labelSubtareas.Visible = true;
                labelSubtareas.Text = $"{cantSubtareas} subtareas";
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
        }


        public void SetBackColor(Color color)
        {
            panelEstado.BackColor = color;
        }
    }
}
