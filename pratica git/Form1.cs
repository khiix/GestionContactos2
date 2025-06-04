using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratica_git
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        const int MAX_CONTACTOS = 10;
        string[] nombres = new string[MAX_CONTACTOS];
        string[] telefonos = new string[MAX_CONTACTOS];

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAyadir_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;

            for (int i = 0; i < MAX_CONTACTOS; i++)
            {
                if (nombres[i] == null)
                {
                    nombres[i] = nombre;
                    telefonos[i] = telefono;
                    MessageBox.Show("Contacto añadido.");
                    return;
                }
                else if (nombres[i] == nombre)
                {
                    MessageBox.Show("Error: Contacto ya registrado.");
                    return;
                }
            }
            MessageBox.Show("Lista llena.");
        }
    }
}
