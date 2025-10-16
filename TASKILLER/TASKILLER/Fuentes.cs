using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKILLER
{
    public static class Fuentes
    {
        private static PrivateFontCollection pfc = new PrivateFontCollection();
        public static Font Montserrat { get; private set; }

        public static void CargarFuentes()
        {
            pfc.AddFontFile(@"resources\fonts\Montserrat-Regular.ttf");
            Montserrat = new Font(pfc.Families[0], 12);
        }
    }
}
