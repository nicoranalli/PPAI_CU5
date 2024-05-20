using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU5.Entidades
{
    public class Bodega
    {
        private int periodoActualizacion;
        private DateTime fechaUltimaActualizacion;
        private string nombre;
        public Bodega(string nombre, int periodoActualizacion, DateTime fechaUltimaActualizacion)
        {
            this.nombre = nombre;
            this.periodoActualizacion = periodoActualizacion; //en meses
            this.fechaUltimaActualizacion = fechaUltimaActualizacion;
        }
        public bool sosActualizable()
        {
            if (validarPeriocidad()) return true;
            else return false;
        }
        public bool validarPeriocidad()
        {
            DateTime diaHoy = DateTime.Now;
            TimeSpan diferencia = diaHoy.Subtract(fechaUltimaActualizacion);
            int diasDeDiferencia = diferencia.Days;
            if (diasDeDiferencia > (periodoActualizacion * 30)) { return true; }
            else { return false; }
        }
        public string getNombre()
        {
            return this.nombre;
        }



        public void ActualizarBodega(Dictionary<string, Dictionary<string, object>> listVinoActualizar, 
            List<Vino> vinos
            )
        {
            foreach (var item in listVinoActualizar)
            {
                bool banderaCrear = false;
                if (this.esDeBodega(item.Value["bodega"].ToString()))
                {
                    foreach(var vino in vinos)
                    {
                        if (vino.getNombre() == item.Key && vino.getAñada().ToString() == item.Value["año"].ToString())
                        {
                            Console.WriteLine($"Vino {item.Key} fue encontrado y se tiene que actualizar");
                        }
                        //Console.WriteLine($"Vino {item.Key} {item.Value["año"]} vino {vino.getNombre()} {vino.getAñada()}");
                    }
                    //no se encontro vino
                    if (!banderaCrear)
                    {
                        Console.WriteLine($"Vino {item.Key} no fue encontrado y se tiene que crear");
                    }
                }
            }
        }
        public bool esDeBodega(string NombreBodega)
        {
            if (NombreBodega == this.nombre)
            {
                return true;
            }
            return false;
        }
        
    }
}
