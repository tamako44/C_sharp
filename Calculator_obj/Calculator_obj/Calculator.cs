using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_obj
{
    public delegate void UpdateState(string state);

    public class Calculator
    {
        internal State state;  //property of calcultor  

        public UpdateState updateState;

        internal void calculate(string input)
        {
            //need implement calculate number

            if (updateState != null)
            {
                updateState(input);
            }
        }
    }
}
