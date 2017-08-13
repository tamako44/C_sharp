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
        //int inputStatus = (int)Status.init;

        Stack<string> inputStack = new Stack<string>();

        string[] numberArray = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        string[] spOperatorArray = new string[] { "sqrt", "power", "integral", "=" };

        decimal numMax = Decimal.MaxValue;
        decimal num1 = Decimal.MaxValue; //Last number
        decimal num2 = Decimal.MaxValue; //First number
        int stackCount;
        int stackIndex;
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

            //bool isNumber = numberArray.Contains(input);

            switch (input)
            {
                case "C":
                    DisplayLabel.Text = "0";
                    num1 = numMax;
                    num2 = numMax;
                    inputStack.Clear();
                    break;

                default:
                    if (isSpOperator(input) == false)
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
                            if(isNumber(input))
                            {
                                DisplayLabel.Text = input;
                                inputStack.Push(input);
                            }
                            inputStack.Push(input);
                        }
                    }
                    else
                    {
                        //foreach (string pop in inputStack)
                        stackCount = inputStack.Count;
                        int n = 0;
                        while (++n < stackCount)
                        {
                            pop = inputStack.Pop();
                            if (isNumber(pop))
                            {
                                if (num1 == numMax)
                                {
                                    num1 = Int32.Parse(pop);
                                }
                                else
                                {
                                    num2 = Int32.Parse(pop);
                                }
                            }
                            else
                            {
                                operatorSign = pop;
                            }

                            switch (input)
                            {
                                case "=":
                                    if ((num1 != numMax) && (num2 != numMax))
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
                                            case "percent":
                                                num1 = num1 * 1;
                                                break;
                                        }
                                        num2 = numMax;
                                        operatorSign = null;
                                    }
                                    break;
                                case "sqrt":
                                    num1D = Convert.ToDouble(num1);
                                    num1 = Convert.ToInt32(Math.Sqrt(num1D));
                                    break;
                                case "power":
                                    num1D = Convert.ToDouble(num1);
                                    num1 = Convert.ToInt32(Math.Pow(num1D, 2));
                                    break;
                                case "integral":
                                    //if ((num1 == 0))
                                    //{
                                    //    inputStack.Clear();
                                    //}
                                    //else
                                    //    num1 = 1 / num1;
                                    num1 = 1 / num1;
                                    break;
                            }
                        }

                        if ((num1 == 0) && (operatorSign == "/"))
                        {
                            DisplayLabel.Text = "Error";
                        }
                        else
                        {
                            DisplayLabel.Text = num1.ToString();
                        }
                    }
                    break;
            }

        }



        public bool isNumber(string input)
        {
            return numberArray.Contains(input.Substring(0, 1));
        }

        public bool isSpOperator(string input)
        {
            return spOperatorArray.Contains(input);
        }

    }
}