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
            labelListaRoles.Font = new Font(Fuentes.MontserratBold.FontFamily, 30, FontStyle.Bold);
            this.d = datos;
            this.u = usuario;
            
            CargarEstilos();


            foreach (Rol r in d.listaRoles) 
            {
                TarjetaRol rol = new TarjetaRol();
                rol.SetDatos(r);
                flowLayoutPanelListaRoles.Controls.Add(rol);

            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            flowLayoutPanelListaRoles.Left = (this.ClientSize.Width - flowLayoutPanelListaRoles.Width) / 2;
            flowLayoutPanelListaRoles.Top = (this.ClientSize.Height - flowLayoutPanelListaRoles.Height) / 2;
        }

        private void CargarEstilos()
        {
            labelListaRoles.Font = new Font(Fuentes.MontserratBold.FontFamily, 50, FontStyle.Bold);
            labelListaRoles.ForeColor = Color.FromArgb(240, 0, 110);
            toolStripLabelNombre.Text = "Usuario: " + u.Nombre + " " + u.Apellido;
            toolStripLabelNombre.Font = new Font(Fuentes.MontserratBold.FontFamily, 12);
            toolStripDropDownButton1.Font = new Font(Fuentes.MontserratBold.FontFamily, 12);

        }

        private void inicioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormInicio f = new FormInicio(d, u);
            f.Show();
            this.Close();
        }
        private void proyectosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormListaProyectos f = new FormListaProyectos(d, u);
            f.Show();
            this.Close();
        }
        private void usuariosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormListaUsuarios f = new FormListaUsuarios(d, u);
            f.Show();
            this.Close();
        }
        private void rolesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormListaRoles f = new FormListaRoles(d, u);
            f.Show();
            this.Close();
        }
        private void crearNuevoProyectoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormCrearProyecto f = new FormCrearProyecto(d, u);
            f.Show();
            this.Close();
        }
        private void crearNuevoUsuarioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Rol r = new Rol();
            r = d.listaRoles.FirstOrDefault(t => t.Nombre == "Administrador");

            if (u.Rol == r.Id)
            {
                FormCreacionUsuario f = new FormCreacionUsuario(d, u);
                f.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No tienes permisos para crear usuarios.", "Permisos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
