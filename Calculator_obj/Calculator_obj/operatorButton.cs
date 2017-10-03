using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_obj
{
    class OperatorButton : Button
    {
        public Calculator calculator;

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }
    }

    /// <summary>
    /// For ["+", "-", "X", "/"]
    /// </summary>
    class BasicOpButton : OperatorButton
    {
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            calculator.OnOpStateChange(this.Name);
        }
    }

    /// <summary>
    /// For ["%", " √ ", "x²", "¹/x", "±"]
    /// </summary>
    class SpOpButton : OperatorButton
    {
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            calculator.OnSpOpeStateChange(this.Name);
        }
    }

    /// <summary>
    /// For ["="]
    /// </summary>
    class EqualButton : OperatorButton
    {
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            calculator.OnEqualStateChange(this.Name);
        }
    }


}
