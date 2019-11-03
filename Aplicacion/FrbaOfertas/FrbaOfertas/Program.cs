using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas
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
            //Application.Run(new Logeo(5,3));

            //For testing
            Application.Run(new AbmProveedor.AbmProveedor());
            //Application.Run(new AbmCliente.AbmCliente());
            //Application.Run(new AbmRol.AbmRol());
        }
    }
}
