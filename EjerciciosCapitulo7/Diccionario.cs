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
   
    public partial class Diccionario : Form
    {
        Hashtable diccionario;
        public Diccionario()
        {
            InitializeComponent();
            diccionario = new Hashtable();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            diccionario.Add(PalabratextBox.Text,DefiniciontextBox.Text);
            PalabratextBox.Text = "";
            DefiniciontextBox.Text = "";
        }

        private void DefiniciontextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Listarbutton_Click(object sender, EventArgs e)
        {
            foreach(DictionaryEntry datos in diccionario)
            {
                DatoslistBox.Items.Add(datos.Key.ToString()+": "+datos.Value.ToString());
            }

        }

       
    }
}
