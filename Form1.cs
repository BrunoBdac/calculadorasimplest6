using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_da_T6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
                
    enum Operacao
        {
            soma,
            subtrai,
            divide,
            multiplica,
            nenhuma
        }
        static Operacao ultimaOperacao = Operacao.nenhuma;
        
           List<double> listaDeNumeros = new List<double>();
        private void fazerCalculo(Operacao ultimaOperacao)
        {
            List<double> listaDeNumeros = new List<double>();

            switch (ultimaOperacao)
            {
                
                case Operacao.soma:
                    listaDeNumeros = textBoxDisplay.Text.Split('+').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] + listaDeNumeros[1]).ToString();
                    break;
                case Operacao.subtrai:
                    listaDeNumeros = textBoxDisplay.Text.Split('-').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] - listaDeNumeros[1]).ToString();
                    break;
                case Operacao.divide:
                    listaDeNumeros = textBoxDisplay.Text.Split('/').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] / listaDeNumeros[1]).ToString();
                    break;
                case Operacao.multiplica:
                    listaDeNumeros = textBoxDisplay.Text.Split('x').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] * listaDeNumeros[1]).ToString();
                    break;
                case Operacao.nenhuma:
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text +=  "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "5";
        }

        private void limpar(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();

        }

        private void divisao(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacao.nenhuma)
            {
                ultimaOperacao = Operacao.divide;
            }
            else
            {
                fazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void apagar(object sender, EventArgs e)
        {
           if (textBoxDisplay.Text.Length > 0)
            {
                textBoxDisplay.Text =
                textBoxDisplay.Text.Remove(textBoxDisplay.TextLength - 1, 1);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "2";
        }

        private void copiar(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxDisplay.Text); 
        }

        private void multiplicacao(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacao.nenhuma)
            {
                ultimaOperacao = Operacao.multiplica;
            }
            else
            {
                fazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "3";
        }

        private void subtracao(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacao.nenhuma)
            {
                ultimaOperacao = Operacao.subtrai;
            }
            else
            {
                fazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "8";
        }

        private void buttonNum_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacao.nenhuma)
            {
                textBoxDisplay.Clear();
            }

            textBoxDisplay.Text += (sender as Button).Text ;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "9";
        }

        private void soma(object sender, EventArgs e)
        {
            if(ultimaOperacao == Operacao.nenhuma)
            {
                ultimaOperacao = Operacao.soma;
            }
            else
            {
                fazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
           if (ultimaOperacao != Operacao.nenhuma)
            {
                fazerCalculo(ultimaOperacao);
            }
            ultimaOperacao = Operacao.nenhuma;
        }
    }
}
