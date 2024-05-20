using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NuGet.Protocol.Core.Types;
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
        Bodega bodegaSeleccionada;
        List<Bodega> bodegasActualizables;
        ApiDatosVino configAPI;
        List<Vino> vinosAActualizarOCrear;
        List<Vino> vinosDeTodasLasBodegas;
        #endregion

        #region Constructor
        public GestorActualizacion(PantallaNovedades pantallaNovedades, ApiDatosVino configAPI)
        {
            this.pantallaNovedades = pantallaNovedades;
            this.configAPI = configAPI;
        }

        public void obtenerBodegas(List<Bodega> Bodegas)
        {
            this.bodegas = Bodegas;
        }
        public void obtenerVinos(List<Vino> vinos)
        {
            vinosDeTodasLasBodegas = vinos;
        }

        #endregion

        #region Metodos

        #endregion

        public List<Bodega> buscarBodegasActualizables()
        {
            bodegasActualizables = new List<Bodega>();
            foreach (Bodega bodega in bodegas)
            {
                if (bodega.sosActualizable()) 
                {
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
            foreach (Bodega bodega in bodegasActualizables) 
            {
                if (BodegaSeleccionada == bodega.getNombre()) 
                { 
                    bodegaSeleccionada = bodega; 
                };
            }
            obtenerActualizaciones(); // Va a la API y guarda en un atributo los vinos a actualizar
            Console.WriteLine("Vinos actuales...");
            Console.WriteLine(mostrarVinos(vinosDeTodasLasBodegas));
            Console.WriteLine("Vinos actualizados...");
            actualizarVinosBodega();
            Console.WriteLine(mostrarVinos(vinosDeTodasLasBodegas));
            ; 
        }
        public void obtenerActualizaciones()
        {
            //Aca simulamos una llamada a la API que trae una lista de vinos a actualizar o crear.
            vinosAActualizarOCrear = configAPI.obtenerActualizacionesVinos();
        }
        public void actualizarVinosBodega()
        {
            foreach (Vino vinoAActualizarOCrear in vinosAActualizarOCrear)
            {
                // Recorre los vinos de todas la bodegas y me devuelve el primer vino que pertenece a esa bodega
                Vino vinoExistente = vinosDeTodasLasBodegas.FirstOrDefault((vino) => (vino.getAniada() == vinoAActualizarOCrear.getAniada()) && (vino.getNombre() == vinoAActualizarOCrear.getNombre()));
                if (vinoExistente != null) //Si existe el vino hay que modificarlo
                {
                    vinoExistente.setPrecio(vinoAActualizarOCrear.getPrecio());
                    vinoExistente.setNotaDeCata(vinoAActualizarOCrear.getNotaDeCata());
                    vinoExistente.setImagenEtiqueta(vinoAActualizarOCrear.getImagenEtiqueta());
                }
                else //Si no existe el vino hay que crearlo.
                {
                    Vino vinoNuevo = new Vino
                    (
                        vinoAActualizarOCrear.getAniada(),
                        vinoAActualizarOCrear.getImagenEtiqueta(),
                        vinoAActualizarOCrear.getNombre(),
                        vinoAActualizarOCrear.getNotaDeCata(),
                        vinoAActualizarOCrear.getPrecio(),
                        bodegaSeleccionada,
                        vinoAActualizarOCrear.getVarietales(),
                        vinoAActualizarOCrear.GetMaridajes()
                    );
                    vinosDeTodasLasBodegas.Add(vinoNuevo);
                }
            }
        }

        
        public string mostrarVinos(List <Vino> listaVinos)
        {
            string vinosEnString = "";
            foreach (Vino vino in listaVinos)
            {
                vinosEnString += vino.ToString();
            }
            return vinosEnString;
        }
        
    }


}
