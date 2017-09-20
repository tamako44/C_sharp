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
        string[] spOperatorArray = new string[] { "sqrt", "power", "inverse", "percent" };
        string[] operatorArray = new string[] { "+", "-", "X", "/" };

        int stackCount;
        decimal numMax = Decimal.MaxValue;
        decimal num1 = Decimal.MaxValue; //For first pop number. Second input
        decimal num2 = Decimal.MaxValue; //For second pop number. First input
        decimal num1Temp = Decimal.MaxValue;
        string operatorSign = null;
        string operatorSignTemp = null;
        string popTmp;
        string pop;
        string inputTemp;
        double num1D; //Decimal
        bool operatorStatus = false;


        public Form1()
        {
            InitializeComponent();
            CreateButton();
            CreateLabel();
        }

        /// <summary>
        /// Main function
        /// </summary>
        public void calculate(object sender, EventArgs e)
        {
            Button buttonText = (Button)sender;
            string input = buttonText.Name;

            if (input == "C")
            {
                DisplayLabel.Text = "0";
                num1 = numMax;
                num2 = numMax;
                num1Temp = numMax;
                operatorSign = null;
                operatorStatus = false;
                operatorSignTemp = null;

                inputStack.Clear();
            }
            else
            {       
                if ((isSpOperator(input)) || (input == "=") || (operatorStatus && isOperator(input)))
                {
                    stackCount = inputStack.Count;
                    int n = 0;

                    while (n++ < stackCount)
                    {
                        stackPop(input);
                        calculatorResult(input);
                    }

                    displayResult(input);
                    
                    resetData();
                }
                else
                {
                    stackPush(input);
                    //inputTemp = input;
                }
            }
        }



        /// <summary>
        /// Push the input string to stack
        /// Be called from main function
        /// </summary>
        private void stackPush(string input)
        {
            // If (inputStack.Count > 0) true return inputStack.Pop() (left side), else null (right side)
            popTmp = (inputStack.Count > 0) ? inputStack.Pop() : null;

            if (isOperator(input))
            {
                operatorStatus = true;
            }

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

        /// <summary>
        /// Pop the string and assign to variable
        /// Be called from main function
        /// </summary>
        private void stackPop(string input)
        {
            pop = inputStack.Pop();
            if (isNumber(pop))
            {
                if (num1 == numMax)
                {
                    num1 = Decimal.Parse(pop);
                }
                else
                {
                    num2 = Decimal.Parse(pop);
                }
            }
            else
            {
                operatorSign = pop;
                operatorSignTemp = operatorSign;
                operatorStatus = false;
            }          
        }

        /// <summary>
        /// All calculate in this function
        /// </summary>
        private void calculatorResult(string input)
        {

            if (isOperator(input))
            {
                if ((num1 != numMax) && (num2 != numMax) && (operatorSign != null))
                {
                    normalCalculator();
                    if (isOperator(input))
                    {
                        inputStack.Push(input);
                        operatorStatus = true;
                    }
                }

            }
            else if (input == "=")
            {
                //if (input == inputTemp)
                //{
                //    num1Temp = num1;
                //    num2 = num1Temp;
                //    operatorSign = operatorSignTemp;
                //}


                if ((num1 != numMax) && (num2 != numMax) && (operatorSign != null))
                {
                    normalCalculator();
                }
                else if ((inputStack.Count == 0) && (num2 == numMax))
                {
                    num1Temp = num1;
                    num2 = num1Temp;
                    operatorSign = operatorSignTemp;
                    normalCalculator();
                }
                //normalCalculator();
            }
            else if (isSpOperator(input))
            {
                spCalculator(input);
            }

            
        }

        /// <summary>
        /// Be called from calculatorResult
        /// </summary>
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
        }

        /// <summary>
        /// Be called from calculatorResult
        /// </summary>
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
                case "inverse":
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
        }

        /// <summary>
        /// Be called from main function
        /// </summary>
        private void displayResult(string input)
        {
            if ((num1 == 0) && ((operatorSign == "/") || (input == "inverse")))
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


        /// <summary>
        /// The most commonly used methods as below.
        /// </summary>

        // Reset 
        private void resetData()
        {
            num1 = numMax;
            num2 = numMax;
            operatorSign = null;
        }

        // Check the input is number or not
        private bool isNumber(string input)
        {
            return numberArray.Contains(input.Substring(0, 1));
        }

        // Check the operator is speacial operator or not ["%", " √ ", "x²", "¹/x"], return boolean
        private bool isSpOperator(string input)
        {
            return spOperatorArray.Contains(input);
        }

        // Check the operator is normal operator or not ["+", "-", "X", "/"], return boolean
        private bool isOperator(string input)
        {
            return operatorArray.Contains(input);
        }

    }
}