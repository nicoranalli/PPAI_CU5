using Newtonsoft.Json;
using PPAI_CU5.Base_De_Datos;
using PPAI_CU5.Entidades;
using PPAI_CU5.Gestor;
using PPAI_CU5.Ventanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        ResultadoListadoActualizaciones ventanaActualizaciones;
        public PantallaNovedades()
        {
            InitializeComponent();
            gestorActualizacion = new GestorActualizacion(this);
            baseDeDatos = new Datos(gestorActualizacion);
            ventanaActualizaciones = new ResultadoListadoActualizaciones();
            vinoApi vinoApi = new vinoApi();
            vinoApi.obtenerActualizacionesVino();

        }

        private void ActualizacionVinos_Load(object sender, EventArgs e)
        {
            baseDeDatos.inicializarDatos();
            configurarGridBodegas();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            gestorActualizacion.importarActualizaciones();
            btnActualizar.Hide();
            gridBodegas.Show();
            btnSeleccionBodegas.Show();
            btnSeleccionBodegas.Enabled = false;
        }

        public void solicitarSeleccionBodegas(List<Bodega> bodegasActualizables)
        {
            
            for (int i = 0; i < bodegasActualizables.Count; i++) { gridBodegas.Rows.Add(i +1, bodegasActualizables[i].getNombre()); }
        }


        private void gridBodegas_SelectionChanged(object sender, EventArgs e)
        {
            validarSeleccionBodegas();
        }

        private void configurarGridBodegas()
        {
            gridBodegas.Hide();
            btnSeleccionBodegas.Hide();
            gridBodegas.MultiSelect = true;
        }
        private void validarSeleccionBodegas()
        {
            if (gridBodegas.SelectedRows.Count == 1)
            {
                btnSeleccionBodegas.Enabled = true;
            }
            else
            {
                btnSeleccionBodegas.Enabled = false;

            }
        }


        private void btnSeleccionBodegas_Click(object sender, EventArgs e)
        {
            btnSeleccionBodegas.Enabled = false ;
            foreach (DataGridViewRow fila in gridBodegas.SelectedRows)
            {
                string nombreBodega = fila.Cells[1].Value.ToString();
                tomarSeleccionBodega(nombreBodega);
            }
            ventanaActualizaciones.ShowDialog();
            
        }

        private void tomarSeleccionBodega(string bodegaSeleccionada)
        {
            gestorActualizacion.tomarSeleccionBodega(bodegaSeleccionada);
        }

        private void gridBodegas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
