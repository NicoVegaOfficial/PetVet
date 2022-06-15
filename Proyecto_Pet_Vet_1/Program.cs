using System;
using System.Windows.Forms;

namespace Proyecto_Pet_Vet_1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            conexionsqlserver conexion = new conexionsqlserver();
            conexion.abrir();

            conexion.cerrar();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inicio());
        }
    }
}
