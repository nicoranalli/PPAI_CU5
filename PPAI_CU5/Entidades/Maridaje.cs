using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU5.Entidades
{
    public class Maridaje
    {
        string descripcion;
        public string nombre;

        public Maridaje(string descripcion, string nombre)
        {
            this.descripcion = descripcion;
            this.nombre = nombre;
        }
    }
}
