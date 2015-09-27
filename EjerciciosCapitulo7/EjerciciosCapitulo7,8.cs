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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalificacionesArrayList ca = new CalificacionesArrayList();
            ca.Show();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diccionario d = new Diccionario();
            d.Show();
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtencionAClientes ac = new AtencionAClientes();
            ac.Show();
        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgendaTelefonica at = new AgendaTelefonica();
            at.Show();
        }

        private void ejercico82ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadenaJustificada cj = new CadenaJustificada();
            cj.Show();
        }

        private void ejercicio83ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoraFechaDelDia hf = new HoraFechaDelDia();
            hf.Show();
        }

        private void ejercicio84ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SumasConCadenas ac = new SumasConCadenas();
            ac.Show();
        }

        private void ejercicio85ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenarCadenas oc = new OrdenarCadenas();
            oc.Show();
        }

        private void ejercicio1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DivisionDePalabras dp = new DivisionDePalabras();
            dp.Show();
        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Costos c = new Costos();
            c.Show();
        }
    }
}
