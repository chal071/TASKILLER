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
    public partial class FormListaRoles : Form
    {
        private Datos d;
        private Usuario u;
        public FormListaRoles(Datos datos, Usuario usuario)
        {
            InitializeComponent();
            this.Resize += Form1_Resize;
            labelListaRoles.Font = new Font("Montserrat", 30, FontStyle.Bold);
            this.d = datos;
            this.u = usuario;
            toolStripLabelNombre.Text = "Usuario: " + u.Nombre + " " + u.Apellido;
            CargarEstilos();
            toolStripDropDownButton1.Font = new Font(Fuentes.MontserratBold.FontFamily, 12);


            foreach (Rol r in d.listaRoles) 
            {
                TarjetaRol rol = new TarjetaRol();
                rol.SetDatos(r);
                flowLayoutPanelListaRoles.Controls.Add(rol);

            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            panelListaRolesResp.Left = (this.ClientSize.Width - panelListaRolesResp.Width) / 2;
            panelListaRolesResp.Top = (this.ClientSize.Height - panelListaRolesResp.Height) / 2;
        }

        private void CargarEstilos()
        {
            labelListaRoles.Font = new Font("Montserrat", 50, FontStyle.Bold);
            labelListaRoles.ForeColor = Color.FromArgb(240, 0, 110);

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

        private void FormListaRoles_Load(object sender, EventArgs e)
        {

        }
    }
}
