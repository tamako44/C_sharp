using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_obj
{
    class Display
    {
        public void updateLb(string input, OnUpdateState updateState)
        {
            if (updateState != null)
            {
                updateState(input);
            }
        }
    }
}
