using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU5.Entidades
{
    public class TipoUva
    {
        string descripcion;
        string nombre;

        public TipoUva(string descripcion, string nombre)
        {
            this.descripcion = descripcion;
            this.nombre = nombre;
        }
        public override string ToString()
        {
            return $"Descripcion uva: {descripcion}\nNombre Uva: {nombre}";
        }
    }
}
