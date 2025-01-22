using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioTelegrama
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

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = 'o'; // Valor predeterminado: ordinario
            int numPalabras = 0;
            double coste = 0;

            // Leo el texto del telegrama
            textoTelegrama = txtTelegrama.Text;

            // Determinar el tipo de telegrama según los RadioButtons seleccionados
            if (rbtnOrdinario.Checked)
            {
                tipoTelegrama = 'o'; // Telegrama ordinario
            }
            else if (rbtnUrgente.Checked)
            {
                tipoTelegrama = 'u'; // Telegrama urgente
            }

            // Calcular el número de palabras del telegrama
            string[] palabras = textoTelegrama.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            numPalabras = palabras.Length;

            // Calcular el coste según el tipo de telegrama
            if (tipoTelegrama == 'o') // Telegrama ordinario
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 2.5 + 0.5 * (numPalabras - 10);
                }
            }
            else if (tipoTelegrama == 'u') // Telegrama urgente
            {
                if (numPalabras <= 10)
                {
                    coste = 5;
                }
                else
                {
                    coste = 5 + 0.75 * (numPalabras - 10);
                }
            }

            // Mostrar el coste en el cuadro de texto
            txtPrecio.Text = $"{coste:F2} euros"; // Formato con dos decimales
            
        }

        
    }
}


