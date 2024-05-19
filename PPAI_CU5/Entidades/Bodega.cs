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
            this.periodoActualizacion = periodoActualizacion;
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
    }
}
