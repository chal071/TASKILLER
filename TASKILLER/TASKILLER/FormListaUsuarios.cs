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
        private ContextMenuStrip menuUsuario;
        private Guid usuarioSeleccionadaId;
        public FormListaUsuarios(Datos datos, Usuario usuario)
        {
            this.d = datos;
            this.u = usuario;
            InitializeComponent();
            dataGridViewListaUsuarios.CellContentClick += dataGridViewUsuario_CellContentClick;
            ConfigurarDataGridView();
            CargarUsuarios();
            generarMenuUsuario();
            SetFontsSize();
        }

        public void CargarUsuarios()
        {
            dataGridViewListaUsuarios.DataSource = null;
            dataGridViewListaUsuarios.Columns.Clear();
            toolStripLabelNombre.Text = "Usuario: " + u.Nombre + " " + u.Apellido;


            var lista = d.listaUsuarios.Select(u => new
            {
                u.Id,
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

            var colId = dataGridViewListaUsuarios.Columns["Id"];
            if (colId != null)
            {
                colId.FillWeight = 1;
                colId.Visible = false;
            }

            if (dataGridViewListaUsuarios.Columns["Nombre"] != null)
            {
                dataGridViewListaUsuarios.Columns["Nombre"].FillWeight = 19;
            }
            if (dataGridViewListaUsuarios.Columns["Apellido"] != null)
            {
                dataGridViewListaUsuarios.Columns["Apellido"].FillWeight = 20;
            }
            if (dataGridViewListaUsuarios.Columns["Mail"] != null)
            {
                dataGridViewListaUsuarios.Columns["Mail"].FillWeight = 30;
            }
            if (dataGridViewListaUsuarios.Columns["Rol"] != null)
            {
                dataGridViewListaUsuarios.Columns["Rol"].FillWeight = 20;
            }
            if (dataGridViewListaUsuarios.Columns["Editar"] != null)
            {
                dataGridViewListaUsuarios.Columns["Editar"].FillWeight = 10;
            }
        }


        public void SetFontsSize()
        {
            labelListaDeUsuarios.Font = new Font(Fuentes.MontserratBold.FontFamily, 30);
            dataGridViewListaUsuarios.Font = new Font(Fuentes.MontserratRegular.FontFamily, 20);
            toolStripLabelNombre.Font = new Font(Fuentes.MontserratRegular.FontFamily, 15);
        }

        private void generarMenuUsuario()
        {
            menuUsuario = new ContextMenuStrip();
            menuUsuario.Items.Add("Modificar", Properties.Resources.editar, MenuModificar_Click);
            menuUsuario.Items.Add("Eliminar", Properties.Resources.borrar, MenuEliminar_Click);
        }

        private void dataGridViewUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridViewListaUsuarios.Columns[e.ColumnIndex].Name == "Editar")
            {
                var idObj = dataGridViewListaUsuarios.Rows[e.RowIndex].Cells["Id"].Value;

                usuarioSeleccionadaId = (Guid)idObj;

                var pos = Cursor.Position;
                menuUsuario.Show(pos);
            }
        }

        private void MenuModificar_Click(object sender, EventArgs e)
        {
            var usuario = d.listaUsuarios.FirstOrDefault(u => u.Id == usuarioSeleccionadaId);

            FormEdicionUsuario f = new FormEdicionUsuario(usuario, d, u);
            f.Show();
            this.Hide();


        }

        private void MenuEliminar_Click(object sender, EventArgs e)
        {
            var usuario = d.listaUsuarios.FirstOrDefault(u => u.Id == usuarioSeleccionadaId);

            var r = MessageBox.Show("¿Seguro que quieres eliminar este usuario?",
                                    "Confirmar",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                d.listaUsuarios.Remove(usuario);
                CargarUsuarios();
            }
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
