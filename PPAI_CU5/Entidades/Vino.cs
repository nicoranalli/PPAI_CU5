using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU5.Entidades
{
    public class Vino
    {
        int añada;
        string imagenEtiqueta;
        string nombre;
        string notaDeCataBodega;
        float precioARS;
        Bodega bodega;
        List<Maridaje> maridajes;
        List<Varietal> varietales;


        public Vino(int añada, string imagenEtiqueta, string nombre, string notaDeCataBodega, float precioARS, Bodega bodega, List<Varietal> varietales, List<Maridaje> maridajes)
        {
            this.añada = añada;
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
            this.añada = añada;
            this.imagenEtiqueta = imagenEtiqueta;
            this.nombre = nombre;
            this.notaDeCataBodega = notaDeCataBodega;
            this.precioARS = precioARS;
            this.bodega = bodega;
            this.varietales = varietales;
        }

        public int getAñada()
        {
            return this.añada;
        }

        public string getNombre()
        {
            return this.nombre;
        }
        public string getCataBodega()
        {
            return this.notaDeCataBodega;
        }
        public string setNotaDeCataBodega(string newNotaCata)
        {
            this.notaDeCataBodega = newNotaCata;
            return this.notaDeCataBodega;
        }
        public float getPrecio()
        {
            return this.precioARS;
        }
        
        public float setPrecio(float  precio)
        {
            this.precioARS = precio;
            return this.precioARS;
        }
        public string getImagen()
        {
            return this.imagenEtiqueta;
        }
        public string setImagenEtiqueta(string newImagen)
        {
            this.imagenEtiqueta = newImagen;
            return this.imagenEtiqueta;
        }
        public Bodega getBodega()
        {
            return this.bodega;
        }
        public string conocerBodega()
        {
            return this.bodega.getNombre();
        }
    }   
}
