using PPAI_CU5.Base_De_Datos;
using PPAI_CU5.Gestor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_CU5
{
    public partial class PantallaNovedades : Form
    {


        GestorActualizacion gestorActualizacion;
        Datos baseDeDatos;
        public PantallaNovedades()
        {
            InitializeComponent();

            gestorActualizacion = new GestorActualizacion(this);

            baseDeDatos = new Datos(gestorActualizacion);
        }

        private void ActualizacionVinos_Load(object sender, EventArgs e)
        {

        }
    }
}
