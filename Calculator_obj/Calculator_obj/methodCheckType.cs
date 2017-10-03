using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_obj
{
    class MethodCheckType
    {
        string[] numberArray = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "." };
        string[] spOperatorArray = new string[] { "sqrt", "power", "inverse", "percent", "plus-minus" };
        string[] operatorArray = new string[] { "+", "-", "X", "/" };


        internal bool isNumber(string input)
        {
            return numberArray.Contains(input.Substring(0, 1));
        }

        // Check the operator is speacial operator or not. ["%", " √ ", "x²", "¹/x", "±"], return boolean
        internal bool isSpOperator(string input)
        {
            return spOperatorArray.Contains(input);
        }

        // Check the operator is normal operator or not. ["+", "-", "X", "/"], return boolean
        internal bool isBasicOperator(string input)
        {
            return operatorArray.Contains(input);
        }

        internal bool isOperator(string input)
        {
            return operatorArray.Contains(input) || spOperatorArray.Contains(input) ? true : false;


        }
    }
}
