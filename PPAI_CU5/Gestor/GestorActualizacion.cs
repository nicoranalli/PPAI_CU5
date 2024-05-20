using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PPAI_CU5;
using PPAI_CU5.Base_De_Datos;
using PPAI_CU5.Entidades;


namespace PPAI_CU5.Gestor
{
    public class GestorActualizacion
    {
        #region Atributos
        PantallaNovedades pantallaNovedades;
        List<Bodega> bodegas;
        List<Vino> vinos;
        Bodega bodegaSeleccionada;
        List<Bodega> bodegasActualizables;
        Dictionary<string, Dictionary<string, object>> listaVinos;
        #endregion

        #region Constructor
        public GestorActualizacion(PantallaNovedades pantallaNovedades)
        {
            this.pantallaNovedades = pantallaNovedades;
        }
        public GestorActualizacion()
        {
            
        }
        public void obtenerBodegas(List<Bodega> Bodegas)
        {
            this.bodegas = Bodegas;
        }
        public void obtenerVinos(List<Vino> Vinos)
        {
            this.vinos = Vinos;
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
        public string getBodegaSeleccionada()
        {
            return this.bodegaSeleccionada.getNombre();
        }
        public void importarActualizaciones()
        {
            pantallaNovedades.solicitarSeleccionBodegas(buscarBodegasActualizables());
        }

        public void tomarSeleccionBodega(string BodegaSeleccionada)
        {
                try 
                {
                        foreach (Bodega bodega in bodegasActualizables)
                        {
                            if (BodegaSeleccionada == bodega.getNombre()) 
                            { 
                                this.bodegaSeleccionada = bodega;
                                return;
                            };
                        }
                        
                        throw new Exception("Bodega no encontrada");
           
            }
                catch (Exception ex)
                {
                    // Aquí puedes manejar la excepción, por ejemplo, imprimir el mensaje de error.
                    Console.WriteLine(ex.Message);
                }
;       }
        public Dictionary<string, Dictionary<string, object>> obtenerActualizaciones()
        {
            return ApiDatosVino.buscarActualizacionesVino();
        }

        public void ActualizarBodega()
        {
            //primero busca los vinos actualizado de la API
            var res = this.obtenerActualizaciones();
            //y luego los manda para la bodegam ademas tenems que pasarle la lista de vinos
            this.bodegaSeleccionada.ActualizarBodega(res,this.vinos);
        }
    }


}
