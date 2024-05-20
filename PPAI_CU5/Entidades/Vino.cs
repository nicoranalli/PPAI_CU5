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
    }
}
