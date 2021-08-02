using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.TiendaRopa
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMenu());
        }

        public static byte[] imageToByteArray(Image imageIn) // Para convertir una imagen a un arreglo de tipo binario
        {
            var ms = new MemoryStream();
            imageIn.Save(ms, imageIn.RawFormat);

            return ms.ToArray();
        }
    }
}
