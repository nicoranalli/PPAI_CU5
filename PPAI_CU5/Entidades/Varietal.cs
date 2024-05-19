using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU5.Entidades
{
    public class Varietal
    {
        string descripcion;
        int porcentajeComposicion;
         TipoUva tipoUva;

        public Varietal(string descripcion, int porcentajeComposicion, TipoUva tipoUva)
        {
            this.descripcion = descripcion;
            this.porcentajeComposicion = porcentajeComposicion;
            this.tipoUva = tipoUva;
        }
    }
}
