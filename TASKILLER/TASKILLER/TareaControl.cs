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
            labelNombreTarea.Font = new Font("Montserrat", 9, FontStyle.Regular);
            labelFechasTarea.Font = new Font("Montserrat", 9, FontStyle.Regular);
            dataGridViewUsuarioDeTarea.Font = new Font("Montserrat", 8, FontStyle.Regular);
            usuariosGlobal = usuarios;
        }
        
        public void SetDatos(Tarea t)
        {
            labelNombreTarea.Text = t.Titulo;
            labelFechasTarea.Text = $"{t.FechaInicio:dd/MM/yyyy} - {t.FechaFinal:dd/MM/yyyy}";

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
            dataGridViewUsuarioDeTarea.ReadOnly = true;

            dataGridViewUsuarioDeTarea.DataSource = usuarios;
        }
    }
}
