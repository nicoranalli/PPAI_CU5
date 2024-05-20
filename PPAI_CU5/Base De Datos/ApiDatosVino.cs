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
        public static Dictionary<string, Dictionary<string, object>> buscarActualizacionesVino()
        {
            // Crear un diccionario con claves de tipo string y valores de tipo int
            Dictionary<string, Dictionary<string, object>> vinosActualizar = new Dictionary<string, Dictionary<string, object>>();
            //aca inicializo los datos que me hacen falta
            //TODO: para actualizar un vino puede que se actualice su precio, su cataBodega
            //este vino se actualiza todos los valores que se puede actualizar
            vinosActualizar["Vino Legendario"] = new Dictionary<string, object> {
                    {"año",2021 },
                    {"bodega","La linda" },
                    {"precio",1900.8f },
                    {"imagen", "mabec654.png"},
                    {"notaDeCataBodega","jugo de naranja con frutos rojo muy rico" },
            };
            //este solo actualiza la imagen
            vinosActualizar["Vino Exclusivo"] = new Dictionary<string, object> {
                    {"año",2022 },
                    {"bodega","La tremenda" },
                    {"imagen", "exclusivo.png"},
            };
            //este solo actuliza el precio
            vinosActualizar["Vino Premium"] = new Dictionary<string, object> {
                    {"año",2020 },
                    {"bodega","La tremenda" },
                    {"precio",1030902.8f }
            };
            //este actualiza precio y nota de cataBodega
            vinosActualizar["Vino Boutique"] = new Dictionary<string, object> {
                    {"año",2019 },
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
            vinosActualizar["Maldonado Malbec"] = new Dictionary<string, object>
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
            vinosActualizar["Sciarra leñas"] = new Dictionary<string, object>
                {
                    {"año",2021 },
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

            return vinosActualizar;
        }

    }
}
