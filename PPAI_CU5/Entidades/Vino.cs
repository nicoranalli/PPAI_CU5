using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PPAI_CU5.Entidades
{
    public class Vino
    {
        #region atributos
        public int aniada;

        public string imagenEtiqueta;

        public string nombre;

        public string notaDeCataBodega;

        public float precioARS;

        DateTime fechaUltimaActualizacion;

        public Bodega bodega;
        public List <Maridaje> maridajes;
        public List <Varietal> varietales;
        #endregion
        #region constructores
        public Vino() { }
        public Vino(int añada, string imagenEtiqueta, string nombre, string notaDeCataBodega, float precioARS, Bodega bodega, List <Varietal> varietales, List <Maridaje> maridajes)
        {
            this.aniada = añada;
            this.imagenEtiqueta = imagenEtiqueta;
            this.nombre = nombre;
            this.notaDeCataBodega = notaDeCataBodega;
            this.precioARS = precioARS;
            this.bodega = bodega;
            this.varietales = varietales;
            this.maridajes = maridajes;
        }
        public Vino(int añada, string imagenEtiqueta, string nombre, string notaDeCataBodega, float precioARS, Bodega bodega, List<Varietal> varietales)
        {
            this.aniada = añada;
            this.imagenEtiqueta = imagenEtiqueta;
            this.nombre = nombre;
            this.notaDeCataBodega = notaDeCataBodega;
            this.precioARS = precioARS;
            this.bodega = bodega;
            this.varietales = varietales;
        }
        //Constructor de los vinos a actualizar
        public Vino(string nombre, float precioARS, int añada, string imagenEtiqueta, string notaDeCataBodega)
        {
            this.nombre = nombre;
            this.precioARS = precioARS;
            this.aniada = añada;
            this.imagenEtiqueta = imagenEtiqueta;
            this.notaDeCataBodega = notaDeCataBodega;
        }
        public Vino(string nombre, float precioARS, int añada, string imagenEtiqueta, string notaDeCataBodega, List<Maridaje> maridajes, List<Varietal> varietales)
        {
            this.nombre = nombre;
            this.precioARS = precioARS;
            this.aniada = añada;
            this.imagenEtiqueta = imagenEtiqueta;
            this.notaDeCataBodega = notaDeCataBodega;
        }
        #endregion
        #region getters y setters
        public void setPrecio(float value)
        {
            if (value > 0) { this.precioARS = value;}
            else { this.precioARS = 0; }
        }
        public void setNotaDeCata(string nuevaNotaDeCata) { this.notaDeCataBodega = nuevaNotaDeCata; }
        public void setImagenEtiqueta(string nuevaImagenEtiqueta) { this.imagenEtiqueta = nuevaImagenEtiqueta; }
        public string getNombre() { return nombre;}
        public int getAniada() { return aniada;}
        public float getPrecio() { return precioARS; }
        public string getNotaDeCata() { return notaDeCataBodega; }
        public string getImagenEtiqueta() { return imagenEtiqueta; }
        public void setBodega(Bodega bodega) { this.bodega = bodega; }

        public Bodega GetBodega() { return bodega; }

        public List<Varietal> getVarietales() { return varietales; }
        public List<Maridaje> GetMaridajes() { return maridajes; }
        #endregion
        #region metodos
        public override string ToString()
        {
            return $"Nombre: {nombre},\nAniada: {aniada}\nImagen etiqueta: {imagenEtiqueta}\nNota de cata de bodega: {notaDeCataBodega}\nPrecio:{precioARS}\n\n";
        }
        public string mostrarVarietales()
        {
            string varietalesString = "";
            foreach(var varietal in varietales)
            {
                varietalesString += varietal.ToString();
            }
            return varietalesString;
        }
        #endregion
    }
}
