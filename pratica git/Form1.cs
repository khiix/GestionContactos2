using Microsoft.VisualBasic;
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

        private const int MAX_CONTACTOS = 10;
        private string[] nombres = new string[MAX_CONTACTOS];
        private string[] telefonos = new string[MAX_CONTACTOS];

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnAyadir_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            bool isValid = true;
            for (int i = 0; i < MAX_CONTACTOS && isValid; i++)
            {
                if (nombres[i] == null)
                {
                    nombres[i] = nombre;
                    telefonos[i] = telefono;
                    MessageBox.Show("Contacto añadido.");
                    isValid = false;
                }
                else if (nombres[i] == nombre && telefono == telefonos[i])
                {
                    MessageBox.Show("Error: Contacto ya registrado.");
                    isValid = false;
                }
                else if (i == MAX_CONTACTOS - 1)
                {
                    MessageBox.Show("Error: Lista de contactos llena.");
                }
            }
            txtNombre.Clear();
            txtTelefono.Clear();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Ingrese el nombre del contacto a eliminar:", "Eliminar Contacto", "");
            bool encontrado = false;
            if (nombre == "" || nombre == null)
            {
                MessageBox.Show("Error: Nombre no puede estar vacío.");
            }
            else
            {
                for (int i = 0; i < MAX_CONTACTOS && !encontrado; i++)
                {
                    if (nombres[i] == nombre)
                    {
                        nombres[i] = "";
                        telefonos[i] = "";
                        MessageBox.Show("Contacto eliminado.");
                        encontrado = true;
                    }
                }
                if (!encontrado)
                {
                    MessageBox.Show("Error: Contacto no encontrado.");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Ingrese el nombre del contacto a modificar:", "Modificar Contacto", "");
            bool encontrado = false;
            string telefonoNuevo = Interaction.InputBox("Ingrese el nuevo teléfono:", "Modificar Teléfono", "");
            if (nombre == "" || nombre == null)
            {
                MessageBox.Show("Error: Nombre no puede estar vacío.");
            }
            for (int i = 0; i < MAX_CONTACTOS && !encontrado; i++)
            {
                if (nombres[i] == nombre)
                {
                    telefonos[i] = telefonoNuevo;
                    MessageBox.Show("Teléfono actualizado.");
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                MessageBox.Show("Error: Contacto no encontrado.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string listaContactos = "Lista de contactos:\n";
            for (int i = 0; i < MAX_CONTACTOS; i++)
            {
                if (!string.IsNullOrEmpty(nombres[i]))
                {
                    listaContactos += $"Nombre: {nombres[i]}, Teléfono: {telefonos[i]}\n";
                }
            }
            MessageBox.Show(listaContactos);
        }
    }
}