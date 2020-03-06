using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_4
{
    public partial class Form1 : Form
    {
        double memoryValue = 0;
        double result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        double a = 0, b = 0, c = 0; //1 число, 2 число, результат
        char znak = '+';

        private void button19_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
           
                switch (znak)
                {
                    case ('+'):
                        c = a + b;
                        break;
                    case ('-'):
                        c = a - b;
                        break;
                    case ('*'):
                        c = a * b;
                        break;
                    case ('/'):
                            if (b == 0.0)
                            MessageBox.Show("Деление на ноль!");
                            else
                            c = a / b;
                        break;
                    case ('%'):
                        c = a % b;
                        break;
                }
                textBox1.Text = c.ToString();
           
        }

        private void button15_Click(object sender, EventArgs e) //c
        {
            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e) //memory
        {
            memoryValue = Double.Parse(textBox1.Text);
        }

        private void button18_Click(object sender, EventArgs e) //memoryread
        {
            result = memoryValue;
            textBox1.Text = result.ToString();
        }

        private void button20_Click(object sender, EventArgs e) //убрать один знак
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button11_Click(object sender, EventArgs e) //знаки
        {
            a = Convert.ToDouble(textBox1.Text);
            znak = (sender as Button).Text[0];
            textBox1.Clear();

        }
      
        private void button2_Click(object sender, EventArgs e) //цифры
        {
            textBox1.Text += (sender as Button).Text;
        }
    }
}
