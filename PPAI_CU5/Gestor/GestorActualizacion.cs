using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PPAI_CU5;
using PPAI_CU5.Entidades;


namespace PPAI_CU5.Gestor
{
    public class GestorActualizacion
    {
        #region Atributos
        PantallaNovedades pantallaNovedades;
        List<Bodega> bodegas;
        Bodega bodegaSeleccionada;
        List<Bodega> bodegasActualizables;
        #endregion

        #region Constructor
        public GestorActualizacion(PantallaNovedades pantallaNovedades)
        {
            this.pantallaNovedades = pantallaNovedades;
        }
        public void obtenerBodegas(List<Bodega> Bodegas)
        {
            this.bodegas = Bodegas;
        }

        #endregion

        #region Metodos

        #endregion

        public List<Bodega> buscarBodegasActualizables()
        {
            bodegasActualizables = new List<Bodega>();
            foreach (Bodega bodega in bodegas)
            {
                if (bodega.sosActualizable()) {
                    bodegasActualizables.Add(bodega);
                }
            }

            return bodegasActualizables;
        }

        public void importarActualizaciones()
        {
            pantallaNovedades.solicitarSeleccionBodegas(buscarBodegasActualizables());
        }

        public void tomarSeleccionBodega(string BodegaSeleccionada)
        {
                foreach (Bodega bodega in bodegasActualizables) { if (BodegaSeleccionada == bodega.getNombre()) { bodegaSeleccionada = bodega; };
                }
       
;       }
    }


}
