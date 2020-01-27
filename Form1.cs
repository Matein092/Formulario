using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter(@"C:\Users\mateo\Documents\Proyecto integrador I\Formulario\Archivo.txt", true);
            escribir.WriteLine("Nombre     " + "     Carrera     " + "     Edad     " + "¿Usa las duchas de la universidad?");
            try
            {
                
                escribir.WriteLine(tbNombre.Text + "               " + tbCarrera.Text + "            " + tbEdad.Text + "                       " + tbDucha.Text);
                escribir.WriteLine("\n");
                escribir.Close();
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            
        }

        private void btEjecutar_Click(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader(@"C:\Users\mateo\Documents\Proyecto integrador I\Formulario\Archivo.txt");
            String linea;
            try
            {
                linea = leer.ReadLine();
                while(linea != null)
                {
                    richTextBox1.AppendText(linea + "\n");
                    linea = leer.ReadLine();
                }

            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
