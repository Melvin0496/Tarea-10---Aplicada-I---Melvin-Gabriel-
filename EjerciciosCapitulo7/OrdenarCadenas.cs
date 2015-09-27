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
    public partial class OrdenarCadenas : Form
    {
        ArrayList cadena;
        public OrdenarCadenas()
        {
            InitializeComponent();
            cadena = new ArrayList();
        }

        private void Presionabutton_Click(object sender, EventArgs e)
        {
            cadena.Add(PrimeraCadenatextBox.Text);
            cadena.Add(SegundaCadenatextBox.Text);
            cadena.Sort();
            PrimeraCadenatextBox.Clear();
            SegundaCadenatextBox.Clear();
            foreach (string cadenas in cadena)
            {
                OrdenlistBox.Items.Add(cadenas);
            }
            cadena.Clear();
           
        }
    }
}
