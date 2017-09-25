using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_obj
{
    public class numberButton : Button
    {
        public Calculator calculator;

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            calculator.calculate(this.Text);
        }
    }



    /// <summary>
    /// For ["."]
    /// </summary>
    class pointButton : numberButton
    {

    }
}
