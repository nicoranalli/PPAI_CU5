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

        internal bool existeVino(Vino vinoAComprobar, List <Vino> listaVinos)
        {
            return (vinoAComprobar.bodega == this);
        }
        public override string ToString()
        {
            return $"Nombre Bodega: {nombre}\n";
        }
        public void actualizarVinosBodega( Vino vinoAActualizarOCrear, List <Vino> vinosDeTodasLasBodegas)
        {
                // Recorre los vinos de todas la bodegas y me devuelve el  vino que va a actualizar o crear.
                Vino vinoExistente = vinosDeTodasLasBodegas.FirstOrDefault((vino) => (vino.getAniada() == vinoAActualizarOCrear.getAniada()) && (vino.getNombre() == vinoAActualizarOCrear.getNombre()));
                if (vinoExistente != null) //Si existe el vino hay que modificarlo
                {
                    vinoExistente.setPrecio(vinoAActualizarOCrear.getPrecio());
                    vinoExistente.setNotaDeCata(vinoAActualizarOCrear.getNotaDeCata());
                    vinoExistente.setImagenEtiqueta(vinoAActualizarOCrear.getImagenEtiqueta());
                }
        }

    }
}
