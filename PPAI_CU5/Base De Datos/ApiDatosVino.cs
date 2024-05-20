using PPAI_CU5.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace PPAI_CU5.Base_De_Datos
{
    public class ApiDatosVino

    {
        public List<Vino> obtenerActualizacionesVinos()
        {
            string jsonText = File.ReadAllText("C:\\Users\\Pupi\\Desktop\\3af\\DSI\\PPAI\\PPAI\\PPAI_CU5\\vinosAModificar.json");
            List <Vino> vinosAModificarOCrear = JsonConvert.DeserializeObject<List<Vino>>(jsonText);
            return vinosAModificarOCrear;
        }
    }
   
}
