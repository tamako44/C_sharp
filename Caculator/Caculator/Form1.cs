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

        int num1 = -999; //Last number
        int num2 = -999; //First number
        int stackCount;
        int stackIndex;
        string operatorSign = null;
        string operatorSignTmp = null;
        string popTmp;


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
                    num1 = -999;
                    num2 = -999;
                    inputStack.Clear();
                    break;

                default:
                    if (input != "=")
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
                            DisplayLabel.Text = input;
                            inputStack.Push(input);
                        }
                    }
                    else
                    {
                        foreach (string pop in inputStack)
                        {
                            if (isNumber(pop))
                            {
                                if (num1 == -999)
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

                            if ((num1 != -999) && (num2 != -999))
                            {
                                if ((num1 == 0) && (operatorSign == "/"))
                                {
                                    DisplayLabel.Text = "Cannot divide by 0";
                                    break;
                                }
                                else
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
                                            num1 = num2 / num1;
                                            break;
                                    }
                                }
                            }
                        }

                        DisplayLabel.Text = num1.ToString();
                    }
                    break;
            }
            
        }



        public bool isNumber(string input)
        {
            return numberArray.Contains(input.Substring(0, 1));
        }

    }
}
