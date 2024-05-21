using NuGet.Protocol.Core.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU5.Entidades
{
    public class Enofilo
    {
        string nombre;
        string apellido;
        string ImagenPerfil;
        Usuario user;
        List<Siguiendo> Siguiendo;

        public Enofilo(string apellido, string nombre, string ImagenPerfil)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.ImagenPerfil = ImagenPerfil;
            this.Siguiendo = new List<Siguiendo>(); // Inicialización de la lista
            this.user = new Usuario(nombre);
        }

        public bool addSiguiendo(Siguiendo siguiendo)
        {
            this.Siguiendo.Add(siguiendo);
            return true;
        }

        public bool sigueaBodega(Bodega bodega)
        {
            foreach (var siguiendo in Siguiendo)
            {
                if (siguiendo.sosDeBodega(bodega))
                    return true;
            }
            return false;
        }
        public string getNombreUsuario()
        {
            return user.nombre;
        }
    }
}
