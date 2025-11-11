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
    public partial class FormListaUsuarios : Form
    {
        private Datos d;
        public FormListaUsuarios(Datos datos)
        {
            this.d = datos;
            InitializeComponent();
            ConfigurarDataGridView();
            CargarUsuarios();
            SetFontsSize();
        }

        public void CargarUsuarios()
        {

            var lista = d.listaUsuarios.Select(u => new {
                u.Nombre,
                u.Apellido,
                u.Mail,
                Rol = d.listaRoles.FirstOrDefault(r => r.Id == u.Rol)?.Nombre
            }).ToList();

           
            dataGridViewListaUsuarios.DataSource = lista;

            AñadirColumnaBoton();
            JustificarColumnas();
        }

        public void ConfigurarDataGridView()
        {
            dataGridViewListaUsuarios.AutoGenerateColumns = true;
            dataGridViewListaUsuarios.ReadOnly = true;
            dataGridViewListaUsuarios.AllowUserToResizeColumns = false;
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
            dataGridViewListaUsuarios.Columns.Add(colBtn);
        }

        public void JustificarColumnas()
        {
            dataGridViewListaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewListaUsuarios.Columns["Nombre"].FillWeight = 20;
            dataGridViewListaUsuarios.Columns["Apellido"].FillWeight = 20;
            dataGridViewListaUsuarios.Columns["Mail"].FillWeight = 30;
            dataGridViewListaUsuarios.Columns["Rol"].FillWeight = 20;
            dataGridViewListaUsuarios.Columns["Editar"].FillWeight = 10;

        }

        public void SetFontsSize()
        {
            labelListaDeUsuarios.Font = new Font(Fuentes.MontserratBold.FontFamily, 30);
            dataGridViewListaUsuarios.Font = new Font(Fuentes.MontserratRegular.FontFamily, 20);
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
    }
}
