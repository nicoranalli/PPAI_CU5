using PPAI_CU5.Ventanas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU5.Entidades
{
    public class Bodega
    {
        private int periodoActualizacion;
        private DateTime fechaUltimaActualizacion;
        private string nombre;
        public ResultadoListadoActualizaciones result;
        public Bodega(string nombre, int periodoActualizacion, DateTime fechaUltimaActualizacion)
        {
            this.nombre = nombre;
            this.periodoActualizacion = periodoActualizacion; //en meses
            this.fechaUltimaActualizacion = fechaUltimaActualizacion;
            this.result = new ResultadoListadoActualizaciones();
        }
        public bool sosActualizable()
        {
            if (validarPeriocidad()) return true;
            else return false;
        }
        public bool validarPeriocidad()
        {
            DateTime diaHoy = DateTime.Now;
            TimeSpan diferencia = diaHoy.Subtract(fechaUltimaActualizacion);
            int diasDeDiferencia = diferencia.Days;
            if (diasDeDiferencia > (periodoActualizacion * 30)) { return true; }
            else { return false; }
        }
        public string getNombre()
        {
            return this.nombre;
        }



        public void ActualizarBodega(Dictionary<string, Dictionary<string, object>> listVinoActualizar, 
            List<Vino> vinos
            )
        {
            Dictionary<string, string> resultadoVino = new Dictionary<string, string>();
            foreach (var item in listVinoActualizar)
            {
                bool banderaCrear = false;
                
                //entra al ciclo si tiene el mismo nombre
                if (this.esDeBodega(item.Value["bodega"].ToString()))
                {
                    foreach(var vino in vinos)
                    {
                        if (vino.getNombre() == item.Key && vino.getAñada().ToString() == item.Value["año"].ToString())
                        {
                            resultadoVino[item.Key] = "Actualizado";
                            banderaCrear = true;
                            Console.WriteLine($"se actuliza el vino {vino.getNombre()}");
                            if (item.Value.ContainsKey("precio"))
                            {
                                vino.setPrecio((float)Convert.ToDecimal(item.Value["precio"]));
                                Console.WriteLine($"se actulizo su precio a: {vino.getPrecio()}");
                            }
                            if (item.Value.ContainsKey("notaDeCataBodega"))
                            {
                                vino.setNotaDeCataBodega(item.Value["notaDeCataBodega"].ToString());
                                Console.WriteLine($"se nota de cata a: {vino.getCataBodega()}");
                            }
                            if (item.Value.ContainsKey("imagen"))
                            {
                                vino.setNotaDeCataBodega(item.Value["imagen"].ToString());
                                Console.WriteLine($"se actualizo imagen a: {vino.getImagen()}");
                            }

                        }
                    }
                    //no se encontro vino
                    if (!banderaCrear)
                    {
                        resultadoVino[item.Key] = "Creado";
                        //crear marinaje
                        var maridaje = item.Value["marinaje"] as Dictionary<string, string>;
                        var comidaMari = maridaje["nombreComida"];
                        var descripcionMari = maridaje["descripcion"];
                        var mari = new Maridaje(descripcionMari, comidaMari);

                        //crear varietal
                        var varietal = item.Value["varietal"] as Dictionary<string, object>;
                        var descripVar = (string)varietal["descripcionVarietal"];
                        var porcentajeVari = Convert.ToInt32(varietal["porcentaje"]);
                        //crear uva antes de crear el varietal
                        var tipoUva = varietal["tipoUva"] as Dictionary<string, string>;
                        var descripUva = tipoUva["descripcion"];
                        var nombreUva = tipoUva["nombre"];
                        var Uva = new TipoUva(descripUva, nombreUva);
                        var Varietal = new Varietal(descripVar, porcentajeVari, Uva);
                        //Creamos vino
                        var nombreVino = item.Key;
                        var imagen = item.Value["imagen"];
                        var notaCata = item.Value["notaDeCataBodega"];
                        var bodega = this;
                        var precio = item.Value["precio"];
                        var añada = item.Value["año"];
                        //crear lista de varietal
                        var listVarietal = new List<Varietal>();
                        var listMarinaje = new List<Maridaje>();
                        listMarinaje.Add(mari);
                        listVarietal.Add(Varietal);
                        var nuevoVino = new Vino((int)añada, (string)imagen, nombreVino, (string)notaCata, (float)precio, this, listVarietal, listMarinaje);
                        Console.WriteLine($"se creo el vino {nuevoVino.getNombre()} del año {nuevoVino.getAñada()}, y se registro con exito en la bodega {nuevoVino.conocerBodega()}");
                    }
                }

                
            }
            this.result.obtenerResultado(resultadoVino);
        }
        public bool esDeBodega(string NombreBodega)
        {
            if (NombreBodega == this.nombre)
            {
                return true;
            }
            return false;
        }
        
    }
}
