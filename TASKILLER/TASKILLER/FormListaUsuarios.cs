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
        private Usuario u;
        public FormListaUsuarios(Datos datos, Usuario usuario)
        {
            this.d = datos;
            this.u = usuario;
            InitializeComponent();
            ConfigurarDataGridView();
            CargarUsuarios();
            SetFontsSize();
        }

        public void CargarUsuarios()
        {
            toolStripLabelNombre.Text = "Usuario: " + u.Nombre + " " + u.Apellido;

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
            toolStripLabelNombre.Font = new Font(Fuentes.MontserratRegular.FontFamily, 15);
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
