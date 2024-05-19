using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_CU5.Entidades
{
   
    public class vinoApi
    {

        public int añada;
        public string imagenEtiqueta;
        public string nombre;
        public string notaDeCataBodega;
        public int precioARS;
        public List<List<string>> maridaje;
        public List<List<string>> varietal;
        public string tipoUva;


        public void obtenerActualizacionesVino()
        {
            
        }
    }

}

