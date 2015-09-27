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
    public partial class DivisionDePalabras : Form
    {
        public DivisionDePalabras()
        {
            InitializeComponent();
        }

        private void Dividirbutton_Click(object sender, EventArgs e)
        {
            string palabra = CadenatextBox.Text;
            string[] resultado = palabra.Split(new char[] {',','.',';',':',' '});

            for(int x = 0;x < resultado.Length;x++)
            {
                PalabraslistBox.Items.Add(resultado[x]+"\n");
            }
            CadenatextBox.Clear();
        }
    }
}
