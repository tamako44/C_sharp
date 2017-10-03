using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_obj
{
    class NumberStack
    {
        Stack<string> numberStack = new Stack<string>();

        string popTmp;

        internal void push(string input)
        {
            popTmp = (numberStack.Count > 0) ? numberStack.Pop() : null;
            popTmp += input;
            numberStack.Push(popTmp);
        }

        internal decimal pop()
        {
            if (numberStack.Count > 0)
                return Decimal.Parse(numberStack.Pop());
            else
                return 0;
        }

        internal decimal peek()
        {
            if (numberStack.Count > 0)
                return Decimal.Parse(numberStack.Peek());
            else
                return 0;
        }

        internal void clear()
        {
            numberStack.Clear();
        }
    }
}
