using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosCapitulo7
{
    public partial class Costos : Form
    {
        ArrayList arreglo;
        public Costos()
        {
            InitializeComponent();
            arreglo = new ArrayList();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            double costo = Convert.ToDouble(CotostextBox.Text);
            double total = 0;
            arreglo.Sort();
            arreglo.Add(costo);
            
           
            
            
            foreach (double totales in arreglo)
            {
                total += totales;
            }
            
            TotaltextBox.Text = total.ToString();
            OrdenlistBox.Items.Add(costo);
            
            CotostextBox.Clear();

        }

        private void Ordenarbutton_Click(object sender, EventArgs e)
        {
            arreglo.Sort();
            arreglo.Reverse();

            foreach(double elementos in arreglo)
            {
                OrdenarlistBox.Items.Add(elementos);
            }
        }
    }
}
