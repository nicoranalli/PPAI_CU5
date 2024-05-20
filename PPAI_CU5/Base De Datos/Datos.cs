using PPAI_CU5.Entidades;
using PPAI_CU5.Gestor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU5.Base_De_Datos
{
    public class Datos
    {
        GestorActualizacion gestorActualizacion;
        public Datos(GestorActualizacion gestor) 
        {
            this.gestorActualizacion = gestor;
        }
        public void inicializarDatos()
        {
            Bodega bodega1 = new Bodega("La linda", 3, new DateTime(2021, 5, 11));
            Bodega bodega2 = new Bodega("La esperanza", 2, new DateTime(2024, 5, 11));
            Bodega bodega3 = new Bodega("Cambiando", 4, new DateTime(2024, 4, 11));
            Bodega bodega4 = new Bodega("La llegada", 2, new DateTime(2021, 5, 18));
            Bodega bodega5 = new Bodega("La tremenda", 3, new DateTime(2021, 9, 13));
            Bodega bodega6 = new Bodega("La salida", 1, new DateTime(2021, 1, 14));
            List<Bodega> bodegas = new List<Bodega>();
            bodegas.Add(bodega1);
            bodegas.Add(bodega2);
            bodegas.Add(bodega3);
            bodegas.Add(bodega4);
            bodegas.Add(bodega5);
            bodegas.Add(bodega6);
            gestorActualizacion.obtenerBodegas(bodegas);
  

            TipoUva tipoUva1 = new TipoUva("Uva de excelente calidad", "Malbec");
            TipoUva tipoUva2 = new TipoUva("Uva aromática", "Cabernet Sauvignon");
            TipoUva tipoUva3 = new TipoUva("Uva suave y dulce", "Merlot");
            TipoUva tipoUva4 = new TipoUva("Uva robusta", "Syrah");
            TipoUva tipoUva5 = new TipoUva("Uva fresca", "Pinot Noir");

            // Crear instancias de Varietal
            Varietal varietal1 = new Varietal("Varietal frutal", 70, tipoUva1);
            Varietal varietal2 = new Varietal("Varietal especiado", 30, tipoUva2);
            Varietal varietal3 = new Varietal("Varietal dulce", 50, tipoUva3);
            Varietal varietal4 = new Varietal("Varietal robusto", 60, tipoUva4);
            Varietal varietal5 = new Varietal("Varietal fresco", 40, tipoUva5);
            Varietal varietal6 = new Varietal("Varietal mixto", 80, tipoUva1);
            Varietal varietal7 = new Varietal("Varietal aromático", 20, tipoUva2);
            Varietal varietal8 = new Varietal("Varietal suave", 90, tipoUva3);
            Varietal varietal9 = new Varietal("Varietal intenso", 10, tipoUva4);
            Varietal varietal10 = new Varietal("Varietal ligero", 75, tipoUva5);

            // Crear instancias de Maridaje
            Maridaje maridaje1 = new Maridaje("Perfecto con carnes rojas", "Carnes Rojas");
            Maridaje maridaje2 = new Maridaje("Ideal para quesos", "Quesos");
            Maridaje maridaje3 = new Maridaje("Acompaña bien pescados", "Pescados");
            Maridaje maridaje4 = new Maridaje("Combina con postres", "Postres");
            Maridaje maridaje5 = new Maridaje("Excelente con pastas", "Pastas");

            // Crear listas de Varietales
            List<Varietal> listaVarietales1 = new List<Varietal> { varietal1, varietal2 };
            List<Varietal> listaVarietales2 = new List<Varietal> { varietal3, varietal4 };
            List<Varietal> listaVarietales3 = new List<Varietal> { varietal5, varietal6 };
            List<Varietal> listaVarietales4 = new List<Varietal> { varietal7, varietal8 };
            List<Varietal> listaVarietales5 = new List<Varietal> { varietal9, varietal10 };

            // Crear listas de Maridajes
            List<Maridaje> listaMaridajes1 = new List<Maridaje> { maridaje1, maridaje2 };
            List<Maridaje> listaMaridajes2 = new List<Maridaje> { maridaje3, maridaje4 };
            List<Maridaje> listaMaridajes3 = new List<Maridaje> { maridaje5, maridaje1 };
            List<Maridaje> listaMaridajes4 = new List<Maridaje> { maridaje2, maridaje3 };
            List<Maridaje> listaMaridajes5 = new List<Maridaje> { maridaje4, maridaje5 };

    

            // Crear instancias de Vino
            List<Vino> vinos = new List<Vino>
        {
            new Vino(2020, "imagen1.jpg", "Vino de Autor 1", "Notas de cata frescas y frutales", 1500.50f, bodega1, listaVarietales1, listaMaridajes1),
            new Vino(2019, "imagen2.jpg", "Vino Reserva", "Notas de cata intensas y complejas", 2000.75f, bodega2, listaVarietales2, listaMaridajes2),
            new Vino(2020, "imagen3.jpg", "Vino Joven", "Notas de cata ligeras y frescas", 1200.00f, bodega3, listaVarietales3, listaMaridajes3),
            new Vino(2018, "imagen4.jpg", "Vino Gran Reserva", "Notas de cata robustas y especiadas", 2500.25f, bodega4, listaVarietales4, listaMaridajes4),
            new Vino(2022, "imagen5.jpg", "Vino Exclusivo", "Notas de cata suaves y delicadas", 3000.60f, bodega5, listaVarietales5, listaMaridajes5),
            new Vino(2017, "imagen6.jpg", "Vino Clásico", "Notas de cata tradicionales", 1800.40f, bodega1, listaVarietales1, listaMaridajes2),
            new Vino(2023, "imagen7.jpg", "Vino Innovador", "Notas de cata creativas", 2200.90f, bodega2, listaVarietales2, listaMaridajes3),
            new Vino(2020, "imagen8.jpg", "Vino Premium", "Notas de cata exclusivas", 2750.35f, bodega3, listaVarietales3, listaMaridajes4),
            new Vino(2021, "imagen9.jpg", "Vino de la Casa", "Notas de cata caseras", 1600.00f, bodega6, listaVarietales4, listaMaridajes5),
            new Vino(2019, "imagen10.jpg", "Vino Boutique", "Notas de cata artesanales", 2300.10f, bodega6, listaVarietales5, listaMaridajes1),
            new Vino(2018, "imagen11.jpg", "Vino Especial", "Notas de cata especiales", 2100.70f, bodega1, listaVarietales1, listaMaridajes2),
            new Vino(2022, "imagen12.jpg", "Vino Familiar", "Notas de cata familiares", 1450.55f, bodega6, listaVarietales2, listaMaridajes3),
            new Vino(2017, "imagen13.jpg", "Vino Tradicional", "Notas de cata tradicionales", 1950.85f, bodega3, listaVarietales3, listaMaridajes4),
            new Vino(2020, "imagen14.jpg", "Vino Auténtico", "Notas de cata auténticas", 1700.25f, bodega4, listaVarietales4, listaMaridajes5),
            new Vino(2021, "imagen15.jpg", "Vino Legendario", "Notas de cata legendarias", 2900.95f, bodega5, listaVarietales5, listaMaridajes1)
        };

            gestorActualizacion.obtenerVinos(vinos);
        }
    }
}
