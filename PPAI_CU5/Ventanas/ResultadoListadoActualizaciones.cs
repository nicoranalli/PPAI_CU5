using PPAI_CU5.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_CU5.Ventanas
{

    public partial class ResultadoListadoActualizaciones : Form
    {
        Dictionary<string, string> resultadoVinos;
        Bodega bodega;
        public ResultadoListadoActualizaciones()
        {
            InitializeComponent();
            textSalida.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void obtenerResultado(Dictionary<string, string> resultado)
        {
            this.resultadoVinos = resultado;
            for (int i = 0; i < resultado.Count; i++)
            {
                var item = resultado.ElementAt(i);
                datosVinoActualizado.Rows.Add(item.Key, item.Value);
            }
            foreach (var vinos in resultado)
            {
                Console.WriteLine($"vino: {vinos.Key},valor: {vinos.Value}");
            }
        }
    }
}
