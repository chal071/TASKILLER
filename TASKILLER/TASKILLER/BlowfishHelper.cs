using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;

namespace TASKILLER
{
    public static class BlowfishHelper
    {
        public static byte[] Cifrar(string texto, string clave)
        {
            byte[] input = Encoding.UTF8.GetBytes(texto);
            byte[] keyBytes = Encoding.UTF8.GetBytes(clave);

            var cipher = new PaddedBufferedBlockCipher(new BlowfishEngine());
            cipher.Init(true, new KeyParameter(keyBytes));

            return cipher.DoFinal(input);
        }

        public static string Descifrar(byte[] datos, string clave)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(clave);

            var cipher = new PaddedBufferedBlockCipher(new BlowfishEngine());
            cipher.Init(false, new KeyParameter(keyBytes));

            byte[] output = cipher.DoFinal(datos);
            return Encoding.UTF8.GetString(output);


        }
    }
}
