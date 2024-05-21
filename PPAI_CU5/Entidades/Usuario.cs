using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU5.Entidades
{
    
    public class Usuario
    {
        public string nombre {  get; set; }
        public Usuario(string nombre) 
        {
            this.nombre = nombre;
        }
    }
}
