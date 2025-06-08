using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1 {
    public partial class frmCalculadora : Form {
        public frmCalculadora() {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        int operação = 1;

        private void rbSoma_CheckedChanged(object sender, EventArgs e) {
            operação = 1; // Atribui o valor 1 para a operação de soma
        }

        private void rbSubtração_CheckedChanged(object sender, EventArgs e) {
            operação = 2; // Atribui o valor 2 para a operação de subtração
        }

        private void rbMultiplicação_CheckedChanged(object sender, EventArgs e) {
            operação = 3; // Atribui o valor 3 para a operação de multiplicação
        }

        private void rbDivisao_CheckedChanged(object sender, EventArgs e) {
            operação = 4; // Atribui o valor 4 para a operação de divisão
        }

        private void btnCalcular_Click(object sender, EventArgs e) {
            double numero1;
            double numero2;
            double resultado;

            numero1 = double.Parse(textValor1.Text); // Converte o texto do primeiro valor para double
            numero2 = double.Parse(textValor2.Text); // Converte o texto do segundo valor para double

            if (operação == 1)
            {
                resultado = numero1 + numero2; // Realiza a soma
                textResultado.Text = "Resultado: " + resultado.ToString(); // Exibe o resultado na label
            }
            else if (operação == 2)
            {
                resultado = numero1 - numero2; // Realiza a subtração
                textResultado.Text = "Resultado: " + resultado.ToString(); // Exibe o resultado na label
            }
            else if (operação == 3)
            {
                resultado = numero1 * numero2; // Realiza a multiplicação
                textResultado.Text = "Resultado: " + resultado.ToString(); // Exibe o resultado na label
            }
            else if (operação == 4)
            {
                if (numero2 != 0) // Verifica se o divisor é diferente de zero
                {
                    resultado = numero1 / numero2; // Realiza a divisão
                    textResultado.Text = "Resultado: " + resultado.ToString(); // Exibe o resultado na label
                }
                else
                {
                    textResultado.Text = "Erro: Divisão por zero!"; // Exibe mensagem de erro se divisor for zero
                }
            }
        }

        private void textValor1_TextChanged(object sender, EventArgs e) {

        }
    }
}
