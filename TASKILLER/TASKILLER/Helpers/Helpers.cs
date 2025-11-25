using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASKILLER
{
    public static class Helpers
    {
        public static void AplicarFuente(Control control, Font fuente)
        {
            control.Font = fuente;

            foreach (Control c in control.Controls)
            {
                AplicarFuente(c, fuente);
            }
        }
    }
}
