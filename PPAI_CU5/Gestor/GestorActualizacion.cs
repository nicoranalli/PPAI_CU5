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
        List<Enofilo> listaSuscriptores;
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
            this.actualizarVinosBodega();
            this.pantallaNovedades.mostrarActualizaciones(vinosAActualizarOCrear);
            this.buscarSuscriptores(); 
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
                bool existeVino = bodegaSeleccionada.existeVino(vinoAActualizarOCrear, vinosDeTodasLasBodegas);
                if (existeVino)
                {
                    bodegaSeleccionada.actualizarVinosBodega(vinoAActualizarOCrear, vinosDeTodasLasBodegas);
                }
                else
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
        public void buscarEnofilos(List <Enofilo> listaEnofilo)
        {
            this.listaSuscriptores = listaEnofilo;
        }
        public void buscarSuscriptores()
        {
            foreach(var suscriptor in this.listaSuscriptores)
            {
                if (suscriptor.sigueaBodega(this.bodegaSeleccionada))
                {
                    var nombre = suscriptor.getNombreUsuario();
                    Console.WriteLine($"se notifico a {nombre}");
                }
            }
        }
        #endregion

    }


}
