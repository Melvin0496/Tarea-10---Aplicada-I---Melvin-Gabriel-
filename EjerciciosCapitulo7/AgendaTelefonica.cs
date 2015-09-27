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
    public partial class AgendaTelefonica : Form
    {
        ArrayList agenda;
        public AgendaTelefonica()
        {
            InitializeComponent();
            agenda = new ArrayList();
        }
        string nombre;
        string telefono;
        private void Guarbutton_Click(object sender, EventArgs e)
        {
            nombre = Convert.ToString(NomtextBox.Text);
            telefono = Convert.ToString(TeltextBox.Text);

            agenda.Add(nombre);
            agenda.Add(telefono);

            ConrichTextBox.Text = nombre +"\n" +telefono;
            NomtextBox.Text = "";
            TeltextBox.Text = "";
        }

        private void Busbutton_Click(object sender, EventArgs e)
        {
            ConrichTextBox.Clear();
            foreach(string nombre in agenda)
            ConrichTextBox.Text += nombre+"\n";
            
        }
    }
}
