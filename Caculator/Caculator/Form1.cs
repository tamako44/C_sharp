﻿using System;
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

        string[] numberArray = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        string buttonText;

        string num1String = "0";
        string num2String = "0";
        string operatorSign;
        string operatorSignTmp;
        int num1;
        int num2;
        int result;
        int resultTmp;

        public Form1()
        {
            InitializeComponent();
            CreateButton();
            CreateLabel();
        }

        private void displayText(object sender, EventArgs e)
        {
            Button buttonText = (Button)sender;
            this.DisplayLabel.Text = buttonText.Text;
            Console.WriteLine(DisplayLabel.Text);
        }

        public void calculateInput(object sender, EventArgs e)
        {
            Button buttonText = (Button)sender;
            string buttonString = buttonText.Text;

            switch (buttonString)
            {
                case "C":
                    num1String = "0";
                    num2String = "0";
                    result = 0;
                    DisplayLabel.Text = "0";
                    inputStatus = Status.init;
                    break;
                default:
                    inputStatusChange(buttonString);

                    if (inputStatus == Status.num1)
                    {
                        num1 = Int32.Parse(num1String);
                        DisplayLabel.Text = num1.ToString();
                    }
                    else if (inputStatus == Status.num2)
                    {
                        num2 = Int32.Parse(num2String);
                        DisplayLabel.Text = num2.ToString();
                    }
                    else
                    {
                        switch (operatorSign)
                        {
                            case "+":
                                resultTmp = result;
                                resultTmp = num1 + num2;
                                result += resultTmp;
                                //addFunction();
                                break;
                            case "-":
                                //resultTmp = result;
                                //resultTmp = num1 - num2;
                                //result -= resultTmp;
                                //subtractFunction();
                                break;
                            case "=":
                                resultTmp = result;
                                resultTmp = num1 + num2;
                                result += resultTmp;
                                DisplayLabel.Text = num1.ToString();
                                num1String = "0";
                                num2String = "0";
                                inputStatus = Status.num1;
                                break;
                            default:

                                break;
                        }                
                    }
                    break;
            }          
        }

        private void inputStatusChange(string buttonString)
        {
            bool isNumber = numberArray.Contains(buttonString);

            switch (inputStatus)
            {
                case Status.init:
                    if (isNumber)
                    {
                        inputStatus = Status.num1;
                        num1String += buttonString;
                    }
                    else
                    {
                        inputStatus = Status.init;
                        operatorSign = buttonString;
                    }
                    break;
                case Status.num1:
                    if (isNumber)
                    {
                        inputStatus = Status.num1;
                        num1String += buttonString;
                    }
                    else
                    {
                        inputStatus = Status.operatorSign;
                        operatorSign = buttonString;
                    }
                    break;
                case Status.operatorSign:
                    if (isNumber)
                    {
                        inputStatus = Status.num2;
                        num2String += buttonString;
                    }
                    else
                    {
                        inputStatus = Status.init;
                        operatorSign = buttonString;
                    }
                    break;
                case Status.num2:
                    if (isNumber)
                    {
                        inputStatus = Status.num2;
                        num2String += buttonString;
                    }
                    else
                    {
                        inputStatus = Status.init;
                        operatorSign = buttonString;
                    }
                    break;
                case Status.result:

                    break;
            }
            num1 = Int32.Parse(num1String);
            num2 = Int32.Parse(num2String);
        }

       

        public void checkNumber(string buttonString)
        {
            bool isNumber = numberArray.Contains(buttonText);

            if (isNumber)
            {
                buttonText += buttonString;
            }
            else
            {
                buttonText = buttonString;
            }

        }

    }
}
