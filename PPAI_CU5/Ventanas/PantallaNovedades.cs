using Newtonsoft.Json;
using PPAI_CU5.Base_De_Datos;
using PPAI_CU5.Entidades;
using PPAI_CU5.Gestor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_CU5
{
    public partial class PantallaNovedades : Form
    {


        GestorActualizacion gestorActualizacion;
        Datos baseDeDatos;
        public PantallaNovedades()
        {
            InitializeComponent();
            leerJson();
            gestorActualizacion = new GestorActualizacion(this);

            baseDeDatos = new Datos(gestorActualizacion);
        }

        private void ActualizacionVinos_Load(object sender, EventArgs e)
        {

        }


        public void leerJson()
        {
            // Ruta del archivo JSON
            string filePath = "C:\\Program Files\\DatosAPI.json";

            // Leer el archivo JSON
            string jsonContent = File.ReadAllText(filePath);

            // Deserializar el JSON en un objeto de tipo Person
            List<vinoApi> vinos = JsonConvert.DeserializeObject<List<vinoApi>>(jsonContent);

            // Mostrar los datos en la consola o usarlos en tu aplicación
   
            foreach (var vino in vinos)
            {

                Console.WriteLine($"Nombre: {vino.nombre}");
                Console.WriteLine($"Añada: {vino.añada}");
                Console.WriteLine($"Precio: {vino.precioARS} ARS");
                Console.WriteLine("Maridajes:");
                foreach (var maridaje in vino.maridaje)
                {
                    Console.WriteLine($"- {maridaje[0]}: {maridaje[1]}");
                }
                Console.WriteLine("Varietales:");
                foreach (var varietal in vino.varietal)
                {
                    Console.WriteLine($"- {varietal[0]}: {varietal[1]}%");
                }
            }
        }

    }
}
