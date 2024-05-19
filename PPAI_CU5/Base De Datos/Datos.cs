using PPAI_CU5.Entidades;
using PPAI_CU5.Gestor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU5.Base_De_Datos
{
    public class Datos
    {
        GestorActualizacion gestorActualizacion;
        public Datos(GestorActualizacion gestor) 
        {
            this.gestorActualizacion = gestor;
        }
        public void inicializarDatos()
        {
            Bodega bodega1 = new Bodega("La linda", 3, new DateTime(2021, 5, 11));
            Bodega bodega2 = new Bodega("La esperanza", 2, new DateTime(2024, 5, 11));
            Bodega bodega3 = new Bodega("Cambiando", 4, new DateTime(2024, 4, 11));
            Bodega bodega4 = new Bodega("La llegada", 2, new DateTime(2021, 5, 18));
            Bodega bodega5 = new Bodega("La tremenda", 3, new DateTime(2021, 9, 13));
            Bodega bodega6 = new Bodega("La salida", 1, new DateTime(2021, 1, 14));
            List<Bodega> bodegas = new List<Bodega>();
            bodegas.Add(bodega1);
            bodegas.Add(bodega2);
            bodegas.Add(bodega3);
            bodegas.Add(bodega4);
            bodegas.Add(bodega5);
            bodegas.Add(bodega6);
            gestorActualizacion.obtenerBodegas(bodegas);
        }
    }
}
