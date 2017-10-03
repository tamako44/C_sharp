using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator_obj
{
    public delegate void OnUpdateState(string state);

    public class Calculator
    {
        private const decimal numMax = Decimal.MaxValue; // Can not be edited
        private decimal num1 = Decimal.MaxValue; // Save the result to num1
        private decimal num2 = Decimal.MaxValue;       
        private string strOperator = ""; // If input is ["+", "-", "X", "/"]
        private string strSpOperator = ""; // If input is ["%", " √ ", "x²", "¹/x", "±"]
        

        private enum Status { Init, Num1, Num2, BasicOperator, Num1SpOperator, Num2SpOperator, Result, Error }
        Status inputStatus = Status.Init;
 
        public OnUpdateState onStateUpdate;
        MethodCheckType checkType = new MethodCheckType();
        Display updateDisplay = new Display();
        NumberStack numStack = new NumberStack();


        private void NormalCalculate()
        {
            if (num1 != numMax && num2 != numMax)
            {
                switch (strOperator)
                {
                    case "+":
                        num1 = num1 + num2;
                        break;
                    case "-":
                        num1 = num1 - num2;
                        break;
                    case "X":
                        num1 = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            // Set num1 to init value
                            num1 = Decimal.MaxValue;
                            inputStatus = Status.Error;
                        }
                        else
                            num1 = num1 / num2;
                        break;
                    default:
                        break;
                }
            }
            
            //
            //if (inputStatus != Status.Num1 && inputStatus != Status.Num2)
            DisplayResult();


        }

        private void SpCalculate(decimal calculteNum)
        {
            
            if (strSpOperator != "percent")
            {
                if (inputStatus == Status.Num1SpOperator)
                    num1 = ExecuteSpCalculate(calculteNum);
                else
                    num2 = ExecuteSpCalculate(calculteNum);
            }
            else
            {
                // expect the stroperator == "percent"
                // This calculte is iOS style
                if (num1 == numMax && num2 == numMax)
                {
                    // already have ???
                    num1 = 0;
                }
                else if (num1 != numMax && num2 == numMax)
                {
                    num1 = num1 / 100;      
                }
                else if (num1 != numMax && num2 != numMax)
                {
                    if (strOperator == "+" || strOperator == "-")
                    {
                        num2 = num1 * (num2 / 100);
                    }
                    else
                    {
                        num2 = num2 / 100;
                    }                   
                }
                else
                {
                    // X
                }              
            }
            DisplayResult();
        }

        private decimal ExecuteSpCalculate(decimal numTemp)
        {
            double numTempD = double.MaxValue;

            switch (strSpOperator)
            {
                case "sqrt":
                    numTempD = Convert.ToDouble(numTemp);
                    numTemp = Convert.ToDecimal(Math.Sqrt(numTempD));
                    break;
                case "power":
                    numTempD = Convert.ToDouble(numTemp);
                    num1 = Convert.ToDecimal(Math.Pow(numTempD, 2));
                    break;
                case "inverse":

                    if (numTemp == 0)
                    {
                        // Set num1 to init value
                        numTemp = Decimal.MaxValue;
                        inputStatus = Status.Error;
                    }
                    else
                        numTemp = 1 / numTemp;
                    break;

                case "plus-minus":
                    numTemp = 0 - numTemp;
                    break;
            }
            return numTemp;
        }

        private void EqualCalculate()
        {
            if (num2 == numMax)
                // test case : 3 + = = 
                num2 = num1;

            NormalCalculate();   
        }

        private void DisplayResult()
        {
            string strResult = "";

            if (inputStatus == Status.Num1 || inputStatus == Status.Num2)
            {
                strResult = numStack.peek().ToString();
            }
            else if (inputStatus == Status.Num2SpOperator)
            {
                strResult = num2.ToString();
            }
            else if (inputStatus == Status.Error)
            {
                strResult = "Error";
            }
            else
            {
                strResult = num1.ToString();
            }
            updateDisplay.updateLb(strResult, onStateUpdate);
        }


        internal void OnNumStateChange(string input)
        {
            switch (inputStatus)
            {
                case Status.Init:
                    inputStatus = Status.Num1;
                    numStack.push(input);
                    break;

                case Status.Num1:
                    numStack.push(input);
                    break;

                case Status.Num2:
                    numStack.push(input);
                    break;

                case Status.BasicOperator:
                    inputStatus = Status.Num2;
                    numStack.push(input);
                    break;

                case Status.Num1SpOperator:
                    // test case : 8√4 -> 4(num1)
                    inputStatus = Status.Num1;
                    numStack.clear();
                    numStack.push(input);
                    break;

                case Status.Num2SpOperator:
                    // test case :  8 + 4√5 -> 8(num1) + 5(num2) 
                    inputStatus = Status.Num2;
                    numStack.clear();
                    numStack.push(input);
                    break;

                case Status.Result:
                    inputStatus = Status.Num1;
                    numStack.push(input);
                    break;

                default:
                    //nothing to do
                    break;
            }
            DisplayResult();
        }

        internal void OnOpStateChange(string input)
        {
            strOperator = input;
            switch (inputStatus)
            {
                case Status.Init:
                    num1 = 0;
                    break;

                case Status.Num1:
                    num1 = numStack.pop();
                    break;

                case Status.Num2:
                    num2 = numStack.pop();
                    NormalCalculate();
                    break;

                default:
                    // nothing to do 
                    break;
            }
            
            inputStatus = Status.BasicOperator;
            
        }

        internal void OnSpOpeStateChange(string input)
        {
            strSpOperator = input;
            
            switch (inputStatus)
            {
                case Status.Init:
                    inputStatus = Status.Num1SpOperator;
                    num1 = 0;
                    SpCalculate(num1);
                    break;

                case Status.Num1:
                    inputStatus = Status.Num1SpOperator;
                    num1 = numStack.pop();
                    SpCalculate(num1);
                    break;

                case Status.Num2:
                    inputStatus = Status.Num2SpOperator;
                    num2 = numStack.pop();
                    SpCalculate(num2);
                    break;

                case Status.Num1SpOperator:
                    // calculate twice
                    inputStatus = Status.Num1SpOperator;
                    SpCalculate(num1);
                    inputStatus = Status.Num1;
                    break;

                case Status.Num2SpOperator:
                    // calculate twice
                    inputStatus = Status.Num2SpOperator;
                    SpCalculate(num2);
                    inputStatus = Status.Num2;
                    break;

                case Status.Result:
                    inputStatus = Status.Num1SpOperator;
                    SpCalculate(num1);
                    break;

                default:
                    break;
            }

            

        }

        // call execute()
        internal void OnEqualStateChange(string input)
        {
            switch (inputStatus)
            {
                case Status.Init:
                    num1 = 0;
                    break;

                case Status.Num1:
                    num1 = numStack.pop();
                    break;

                case Status.BasicOperator:
                    // speacil calculate. eg: 3+= =>6
                    // 
                    break;

                case Status.Num2:
                    num2 = numStack.pop();
                    break;

                default:
                    break;
            }
            inputStatus = Status.Result;
            EqualCalculate();
        }

        internal void OnCClick(string input)
        {
            num1 = Decimal.MaxValue;
            num2 = Decimal.MaxValue;
            strOperator = "";
            strSpOperator = "";
            inputStatus = Status.Init;
            numStack.clear();
            updateDisplay.updateLb("0", onStateUpdate);
        }

        internal void OnCEClick(string input)
        {
            switch (inputStatus)
            {
                case Status.Num1:
                    numStack.clear();
                    num1 = Decimal.MaxValue;
                    break;

                case Status.Num2:
                    num2 = numStack.pop();
                    num2 = Decimal.MaxValue;
                    break;

                default:
                    break;
            }
            updateDisplay.updateLb("0", onStateUpdate);
        }

        internal void OnBSClick(string input)
        {
            
        }
    }
}
