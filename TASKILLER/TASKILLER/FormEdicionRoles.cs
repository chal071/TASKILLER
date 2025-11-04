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
    public partial class FormEdicionRoles : Form
    {
        private Datos d;
        public FormEdicionRoles(Datos datos)
        {
            InitializeComponent();
            this.d = datos;
        }
    }
}
