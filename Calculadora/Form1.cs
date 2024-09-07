using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnX2_Click(object sender, EventArgs e)
        {
            // Obtener el texto del TextBox
            string input = txtOperaciones.Text;

            // Verificar si el input contiene una letra seguida de '^'
            int index = input.IndexOf('^');
            if (index > 0 && index < input.Length - 1)
            {
                // Obtener la base (letra o número) y el exponente
                string basePart = input.Substring(0, index);
                string exponentPart = input.Substring(index + 1);

                if (double.TryParse(basePart, out double baseNumber) && int.TryParse(exponentPart, out int exponent))
                {
                    // Calcular la potencia
                    double result = Math.Pow(baseNumber, exponent);

                    // Mostrar el resultado en el TextBox
                    txtOperaciones.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido y un exponente válido.");
                }
            }
            else
            {
                MessageBox.Show("Formato incorrecto. Use el formato 'Base^Exponente'.");
            }
        }
    }
}
