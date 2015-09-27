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
    public partial class HoraFechaDelDia : Form
    {
        public HoraFechaDelDia()
        {
            InitializeComponent();
        }
        string formato;
        private void Desplegarbutton_Click(object sender, EventArgs e)
        {
            formato = string.Format("{0:yyyy/dddd/M   hh:mm tt}",DateTime.Now);
            FechalistBox.Items.Add(formato);
        }
    }
}
