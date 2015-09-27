using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosCapitulo7
{
    public partial class SumasConCadenas : Form
    {
        public SumasConCadenas()
        {
            InitializeComponent();
        }

        private void SumasConCadenas_Load(object sender, EventArgs e)
        {

        }

        private void Resultadobutton_Click(object sender, EventArgs e)
        {
            double primerNumero = Convert.ToDouble(PrimerNumerotextBox.Text);
            double segundoNumero = Convert.ToDouble(SegundoNumerotextBox.Text);

            double resultado = primerNumero + segundoNumero;

            if(resultado > 0)
            {
                ResultadotextBox.Text = resultado.ToString();
            }
            else
            {
                ResultadotextBox.Text = "("+resultado.ToString()+")";
            }
            PrimerNumerotextBox.Clear();
            SegundoNumerotextBox.Clear();
        }
    }
}
