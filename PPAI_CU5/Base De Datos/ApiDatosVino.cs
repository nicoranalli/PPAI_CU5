using PPAI_CU5.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_CU5.Base_De_Datos
{
    public class ApiDatosVino
    {
        public static void buscarActualizacionesVino()
        {
            // Crear un diccionario con claves de tipo string y valores de tipo int
            Dictionary<string, Dictionary<string, object>> vinosActualizar = new Dictionary<string, Dictionary<string, object>>();
            //aca inicializo los datos que me hacen falta
            //TODO: para actualizar un vino puede que se actualice su precio, su cataBodega
            //este vino se actualiza todos los valores que se puede actualizar
            vinosActualizar["Apotic RED"] = new Dictionary<string, object> {
                    {"año",2020 },
                    {"bodega","La tremenda" },
                    {"precio",1900.8f },
                    {"imagen", "mabec654.png"},
                    {"notaDeCataBodega","jugo de naranja con frutos rojo muy rico" },
            };
            //este solo actualiza la imagen
            vinosActualizar["Apotic ORANGE"] = new Dictionary<string, object> {
                    {"año",2020 },
                    {"bodega","La tremenda" },
                    {"imagen", "mabecOrange653.png"},
            };
            //este solo actuliza el precio
            vinosActualizar["Labere"] = new Dictionary<string, object> {
                    {"año",2020 },
                    {"bodega","La tremenda" },
                    {"precio",103902.8f }
            };
            //este actualiza precio y nota de cataBodega
            vinosActualizar["malbec San Juan"] = new Dictionary<string, object> {
                    {"año",2020 },
                    {"bodega","La tremenda" },
                    {"precio",120120.8f },
                    {"notaDeCataBodega","hecho en san juan muy rico" }
            };
            //este vino se esta creando y por ende se necesita todos los atributos
            vinosActualizar["MABEC FRUTO ROJOS"] = new Dictionary<string, object>
                {
                    {"año",2000 },
                    {"precio",2000.4f },
                    {"bodega","La tremenda" },
                    {"imagen", "mabec43.png"},
                    {"notaDeCataBodega","vino con gustos especiales fruto rojo" },
                    {"marinaje", new Dictionary<string,string>
                        {
                            {"nombreComida","Queso" },
                            {"descripcion","Ideal para quesos" }
                        }
                    },
                    {"varietal", new Dictionary<string,object>
                        {
                            { "descripcionVarietal" ,"varietal Especializado"}, 
                            //este es un porcentaje que tiene que estar entro 0 y 100, pudiendo ser flotante
                            {"procentaje",80f },
                            {"tipoUva", new Dictionary<string,string>
                                { 
                                    {"descripcion","Uva de excelente calidad" },
                                    {"nombre","Malbec" }
                                }
                            }
                        }
                    }
                };
            // Nuevo vino con todos los atributos
            vinosActualizar["CABERNET SAUVIGNON RESERVA"] = new Dictionary<string, object>
                {
                    {"año",2018 },
                    {"precio",2500.5f },
                    {"bodega","La tremenda" },
                    {"imagen", "cabernet_reserva.png"},
                    {"notaDeCataBodega","aromas a frutas negras con un toque de vainilla" },
                    {"marinaje", new Dictionary<string,string>
                        {
                            {"nombreComida","Carne asada" },
                            {"descripcion","Perfecto para acompañar carnes asadas" }
                        }
                    },
                    {"varietal", new Dictionary<string,object>
                        {
                            {"descripcionVarietal" ,"varietal Premium"},
                            {"porcentaje",85.5f },
                            {"tipoUva", new Dictionary<string,string>
                                {
                                    {"descripcion","Uva de alta calidad" },
                                    {"nombre","Cabernet Sauvignon" }
                                }
                            }
                        }
                    }
                };

            // Otro vino con atributos específicos
            vinosActualizar["CHARDONNAY BLANCO"] = new Dictionary<string, object>
                {
                    {"año",2019 },
                    {"precio",1800.3f },
                    {"bodega","La tremenda" },
                    {"imagen", "chardonnay_blanco.png"},
                    {"notaDeCataBodega","fresco con notas cítricas" },
                    {"marinaje", new Dictionary<string,string>
                        {
                            {"nombreComida","Pescado" },
                            {"descripcion","Excelente para acompañar pescados y mariscos" }
                        }
                    },
                    {"varietal", new Dictionary<string,object>
                        {
                            {"descripcionVarietal" ,"varietal Refrescante"},
                            {"porcentaje",75f },
                            {"tipoUva", new Dictionary<string,string>
                                {
                                    {"descripcion","Uva de buena calidad" },
                                    {"nombre","Chardonnay" }
                                }
                            }
                        }
                    }
                };
            foreach (var vino in vinosActualizar)
            {
                Console.WriteLine($"nombre vino {vino.Key}, año {vino.Value["año"]}, bodega {vino.Value["bodega"]}");
            }

        }

    }
}
