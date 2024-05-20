using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU5.Entidades
{
    public class Maridaje
    {
        string descripcion;
        string nombre;

        public Maridaje(string descripcion, string nombre)
        {
            this.descripcion = descripcion;
            this.nombre = nombre;
        }
        public string Descripcion { get {  return descripcion; } }
        public string Nombre { get {  return nombre; } }
        public string toString() { return $"maridaje: {this.nombre} descripcion: {this.descripcion}"; }
    }
}
