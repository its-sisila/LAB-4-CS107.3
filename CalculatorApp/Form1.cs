using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        private double firstNumber;
        private char currentOperator;
        private bool isNewNumber = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (isNewNumber)
            {
                textBox1.Text = button.Text;
                isNewNumber = false;
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            firstNumber = double.Parse(textBox1.Text);
            currentOperator = button.Text[0];
            isNewNumber = true;
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(textBox1.Text);
            double result = 0;
            switch (currentOperator)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    if (secondNumber != 0)
                        result = firstNumber / secondNumber;
                    else
                        MessageBox.Show("Cannot divide by zero!");
                    break;
            }
            textBox1.Text = result.ToString();
            isNewNumber = true;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            isNewNumber = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
