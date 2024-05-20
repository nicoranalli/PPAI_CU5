using PPAI_CU5.Base_De_Datos;
using PPAI_CU5.Entidades;
using PPAI_CU5.Gestor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_CU5
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            var gestor = new GestorActualizacion();
            var baseDeDatos = new Datos(gestor);
            baseDeDatos.inicializarDatos();
            gestor.buscarBodegasActualizables();
            gestor.tomarSeleccionBodega("La tremenda");
            gestor.ActualizarBodega();

            */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PantallaNovedades());
            
        }
    }
}
