//Darren Joyner
//CSCI 363
//Assignment 1


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csci363DJoynerCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            userInput += "0";
            equation += "0";
            resultBox.Text = userInput;
            equationBox.Text = equation;
        }

        private void One_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            userInput += "1";
            equation += "1";
            resultBox.Text = userInput;
            equationBox.Text = equation;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            userInput += "2";
            equation += "2";
            resultBox.Text = userInput;
            equationBox.Text = equation;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            userInput += "3";
            equation += "3";
            resultBox.Text = userInput;
            equationBox.Text = equation;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            userInput += "4";
            equation += "4";
            resultBox.Text = userInput;
            equationBox.Text = equation;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            userInput += "5";
            equation += "5";
            resultBox.Text = userInput;
            equationBox.Text = equation;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            userInput += "6";
            equation += "6";
            resultBox.Text = userInput;
            equationBox.Text = equation;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            userInput += "7";
            equation += "7";
            resultBox.Text = userInput;
            equationBox.Text = equation;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            userInput += "8";
            equation += "8";
            resultBox.Text = userInput;
            equationBox.Text = equation;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            userInput += "9";
            equation += "9";
            resultBox.Text = userInput;
            equationBox.Text = equation;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            firstOperand = userInput;
            operation = '*';
            equation += "*";
            userInput = string.Empty;
            equationBox.Text = equation;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            firstOperand = userInput;
            operation = '/';
            equation += "/";
            userInput = string.Empty;
            equationBox.Text = equation;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            firstOperand = userInput;
            operation = '+';
            equation += "+";
            userInput = string.Empty;
            equationBox.Text = equation;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            firstOperand = userInput;
            operation = '-';
            equation += "-";
            userInput = string.Empty;
            equationBox.Text = equation;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            savedAns = 0.00;
            equalclicked = false;
            equation = string.Empty;
            userInput = string.Empty;
            firstOperand = string.Empty;
            secondOperand = string.Empty;
            equationBox.Text = string.Empty;

        }

        private void Dot_Click(object sender, EventArgs e)
        {
            resultBox.Text = " ";
            userInput += ".";
            equation += ".";
            resultBox.Text = userInput;
            equationBox.Text = equation;
        }


        private void Equal_Click(object sender, EventArgs e)
        {
            secondOperand = userInput;
            double num1, num2;
            equalclicked = true;

            double.TryParse(firstOperand, out num1);
            double.TryParse(secondOperand, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                savedAns = result;
                resultBox.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                savedAns = result;
                resultBox.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                savedAns = result;
                resultBox.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    savedAns = result;
                    resultBox.Text = result.ToString();
                }
                else
                {
                    resultBox.Text = "Can Not Divide by zero.";
                }
            }

            userInput = resultBox.Text;
        }

        private void Ans_Click(object sender, EventArgs e)
        {
            if (equalclicked == true)
            {
                resultBox.Text = " ";
                userInput += savedAns;
                equation += savedAns;
                resultBox.Text = userInput;
                equationBox.Text = equation;
            }
        }
    }
}
  