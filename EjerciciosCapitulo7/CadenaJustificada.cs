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
    public partial class CadenaJustificada : Form
    {
        public CadenaJustificada()
        {
            InitializeComponent();
        }

        private void Presionarbutton_Click(object sender, EventArgs e)
        {
            string cadena = CadenatextBox.Text;
            string resultado = "";

            if (DerecharadioButton.Checked)
            {
                resultado = cadena.PadRight(10);
                JustificadalistBox.Items.Add(resultado);
            }
            if(IzquierdaradioButton.Checked)
            {
                resultado = cadena.PadLeft(10);
                JustificadalistBox.Items.Add(resultado);
            }
            CadenatextBox.Clear();
            
        }
    }
}
