using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{


    public partial class Form1 : Form
    {
        enum Status { init, num1, operatorSign, num2, result };
        Status inputStatus = Status.init;

        Stack<string> inputStack = new Stack<string>();

        string[] numberArray = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        string[] spOperatorArray = new string[] { "sqrt", "power", "integral", "percent" };
        string[] operatorArray = new string[] { "+", "-", "X", "/" };

        decimal numMax = Decimal.MaxValue;
        decimal num1 = Decimal.MaxValue; //First number
        decimal num2 = Decimal.MaxValue; //Last number
        decimal num1Temp = Decimal.MaxValue;
        decimal displayNum = 0m;
        int stackCount;
        string operatorSign = null;
        string operatorSignTmp = null;
        string popTmp;
        string pop;
        double num1D;


        public Form1()
        {
            InitializeComponent();
            CreateButton();
            CreateLabel();
        }

        public void calculate(object sender, EventArgs e)
        {
            Button buttonText = (Button)sender;
            string input = buttonText.Name;

            if (input == "C")
            {
                DisplayLabel.Text = "0";
                num1 = numMax;
                num2 = numMax;
                operatorSign = null;
                inputStack.Clear();
            }
            else
            {
                if ((isSpOperator(input) == false) && (operatorSign == null) && (input != "="))
                {
                    stackPush(input);
                }
                else
                {
                    stackCount = inputStack.Count;
                    int n = 0;

                    while (n++ < stackCount)
                    {
                        stackPop(input);
                        calculatorResult(input);

                    }

                    displayResult(input);
                }
            }

        }


        private void stackPush(string input)
        {
            popTmp = (inputStack.Count > 0) ? inputStack.Pop() : null;

            if (popTmp != null)
            {
                if (isNumber(popTmp) && isNumber(input))
                {
                    popTmp += input;
                    DisplayLabel.Text = popTmp;
                    inputStack.Push(popTmp);
                    popTmp = null;
                }
                else
                {
                    if (isNumber(input))
                    {
                        DisplayLabel.Text = input;
                    }
                    inputStack.Push(popTmp);
                    inputStack.Push(input);
                }
            }
            else
            {
                if (isNumber(input))
                {
                    DisplayLabel.Text = input;
                    inputStack.Push(input);
                }
                else
                {
                    inputStack.Push(input);
                }
            }
              
        }

        private void stackPop(string input)
        {
            pop = inputStack.Pop();
            if (isNumber(pop))
            {
                if (num1 == numMax)
                {
                    num1 = Decimal.Parse(pop);
                    num1Temp = num1;
                }
                else
                {
                    num2 = Decimal.Parse(pop);
                }
            }
            else
            {
                operatorSign = pop;
            }
            
        }

        private void calculatorResult(string input)
        {
            if (isOperator(input))
            {
                normalCalculator();
                operatorSign = input;
            }
            else if (input == "=")
            {
                if ((num1 != numMax) && (num2 != numMax) && (operatorSign != null))
                    normalCalculator();
               // else if

            }
            else if (isSpOperator(input))
            {
                spCalculator(input);
            }         
        }

        private void normalCalculator()
        {
            switch (operatorSign)
            {
                case "+":
                    num1 = num2 + num1;
                    break;
                case "-":
                    num1 = num2 - num1;
                    break;
                case "X":
                    num1 = num2 * num1;
                    break;
                case "/":
                    if ((num1 == 0))
                    {
                        inputStack.Clear();
                    }
                    else
                        num1 = num2 / num1;
                    break;
            }
            inputStack.Push(num1.ToString());
            num1 = numMax;
            num2 = numMax;
        }

        private void spCalculator(string input)
        {
            switch(input)
            {
                case "sqrt":
                    num1D = Convert.ToDouble(num1);
                    num1 = Convert.ToDecimal(Math.Sqrt(num1D));
                    break;
                case "power":
                    num1D = Convert.ToDouble(num1);
                    num1 = Convert.ToDecimal(Math.Pow(num1D, 2));
                    break;
                case "integral":
                    if (num1 == 0)
                    {
                        inputStack.Clear();
                    }
                    else
                        num1 = 1 / num1;
                    break;
                case "percent":
                    if ((num1 != numMax) && (num2 != numMax))
                    {
                        num1 = num1 * (num2 / 100);
                        num2 = numMax;
                        operatorSign = null;
                    }
                    break;
            }
            inputStack.Push(num1.ToString());
            num1 = numMax;
            num2 = numMax;

        }

        private void displayResult(string input)
        {
            if ((num1 == 0) && ((operatorSign == "/") || (input == "integral")))
            {
                DisplayLabel.Text = "Error";
            }
            else
            {
                if (num1 == numMax)
                    DisplayLabel.Text = "0";
                else
                    DisplayLabel.Text = num1.ToString();
            }
        }

        private bool isNumber(string input)
        {
            return numberArray.Contains(input.Substring(0, 1));
        }

        private bool isSpOperator(string input)
        {
            return spOperatorArray.Contains(input);
        }

        private bool isOperator(string input)
        {
            return operatorArray.Contains(input);
        }

    }
}