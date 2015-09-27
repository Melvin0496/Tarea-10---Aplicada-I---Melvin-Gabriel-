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
    public partial class AtencionAClientes : Form
    {
        Queue fila;
        public AtencionAClientes()
        {
            InitializeComponent();
            fila = new Queue();
        }

        private void Atenderbutton_Click(object sender, EventArgs e)
        {
            fila.Enqueue(ClientestextBox.Text.ToString());
            LlegadalistBox.Items.Add(ClientestextBox.Text);
            ClientestextBox.Text = "";
            
        }

        private void Despacharbutton_Click(object sender, EventArgs e)
        {
           
            SalidalistBox.Items.Add(fila.Dequeue());
        }
    }
}
