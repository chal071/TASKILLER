using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TASKILLER.Properties;

namespace TASKILLER
{
    public static class Fuentes
    {
        private static PrivateFontCollection pfc = new PrivateFontCollection();
        public static Font MontserratRegular { get; private set; }
        public static Font MontserratBold { get; private set; }


        public static void CargarFuentes()
        {
            pfc.AddFontFile(@"resources\fonts\Montserrat-Regular.ttf");
            MontserratRegular = new Font(pfc.Families[0], 12);

            pfc.AddFontFile(@"resources\fonts\Montserrat-SemiBold.ttf");
            MontserratBold = new Font(pfc.Families[0], 12);
        }
    }
}
