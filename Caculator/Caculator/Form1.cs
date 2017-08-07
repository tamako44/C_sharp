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

        string buttonText;

        string num1String = "0";
        string num2String = "0";
        string operatorSignTmp;
        int num1 = -1;
        int num2 = -1;
        string operatorSign = null;
        int result;
        int resultTmp;

        public Form1()
        {
            InitializeComponent();
            CreateButton();
            CreateLabel();
        }

        public void calculate(object sender, EventArgs e)
        {
            Button buttonText = (Button)sender;
            string input = buttonText.Text;

            //bool isNumber = numberArray.Contains(input);

            if (input != "=")
            {
                string popTmp = inputStack.Pop();
                if (isNumber(inputStack.Pop()) && isNumber(input) )
                {
                    popTmp += input;
                    inputStack.Push(popTmp);
                }
                else
                {
                    inputStack.Push(input);
                } 
            }
            else
            {
                foreach (string pop in inputStack)
                {
                    if (isNumber(pop.Substring(0, 1)))
                    {
                        if (num1 == -1)
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

                    if ( (num1 != -1) && (num2 != -1) )
                    {
                        switch(operatorSign)
                        {
                            case "+":
                                num1 = num2 + num1;
                                break;
                            case "-":
                                num1 = num2 - num1;
                                break;
                            case "x":
                                num1 = num2 * num1;
                                break;
                            case "/":
                                num1 = num2 / num1;
                                break;
                        }
                    }
                }
            }
        }



        public bool isNumber(string input)
        {
            return numberArray.Contains(input);
        }

    }
}
