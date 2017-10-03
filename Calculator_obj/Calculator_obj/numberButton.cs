using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_obj
{
    public class NumberButton : Button
    {
        public Calculator calculator;

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            calculator.OnNumStateChange(this.Name);
        }
    }



    /// <summary>
    /// For ["."]
    /// </summary>
    class PointButton : NumberButton
    {
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            calculator.OnNumStateChange(this.Name);
        }

    }
}
