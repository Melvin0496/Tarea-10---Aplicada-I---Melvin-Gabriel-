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
    public partial class CalificacionesArrayList : Form
    {
        ArrayList arreglo;
        public CalificacionesArrayList()
        {
            InitializeComponent();
            arreglo = new ArrayList();
        }
        int i = 0;
        double promedio = 0,suma = 0,valor;

        private void Limpiarbutton_Click(object sender, EventArgs e)
        {
            PromediotextBox.Text = "";
            CalificacioneslistBox.Items.Add("");
            MinimatextBox.Text = "";
            MaximatextBox.Text = "";
            arreglo.Clear();
            i = 0;
            suma = 0;
            promedio = 0;

        }
        public void Menor()
        {
            arreglo.Sort();
            MinimatextBox.Text = arreglo[0].ToString();
        }
        public void Mayor()
        {
            arreglo.Reverse();

            MaximatextBox.Text = arreglo[0].ToString();
        }
        private void Mostrarbutton_Click(object sender, EventArgs e)
        {
            PromediotextBox.Text = promedio.ToString();
            Menor();
            Mayor();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            valor = Convert.ToDouble(CalificaciontextBox.Text);
            arreglo.Add(valor);
            CalificacioneslistBox.Items.Add(valor.ToString());
            i++;
            suma = 0;
            foreach(double total in arreglo)
            {
                suma += total;
            }
            
            promedio = suma / i;
            CalificaciontextBox.Text = "";
        }

    }
}
