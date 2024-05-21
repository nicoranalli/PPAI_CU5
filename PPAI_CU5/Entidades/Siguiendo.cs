using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU5.Entidades
{
    public class Siguiendo
    {
        DateTime fechaInicio = DateTime.Now;
        DateTime fechaFin;
        Bodega bodega;
        public Siguiendo(Bodega bodega)
        {
            this.bodega = bodega;
        }

        public bool sosDeBodega(Bodega bodegaAConocer)
        {
            if (this.bodega == bodegaAConocer)
                return true;
            else return false;
        }
    }
}
