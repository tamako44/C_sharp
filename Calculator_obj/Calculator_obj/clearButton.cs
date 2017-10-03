using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_obj
{
    class ClearButton : Button
    {
        public Calculator calculator;
    }

    class CButton : ClearButton
    {
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            calculator.OnCClick(this.Name);
        }
    }

    class CEButton : ClearButton
    {
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            calculator.OnCEClick(this.Name);
        }
    }

    class BSButton : ClearButton
    {
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            calculator.OnBSClick(this.Name);
        }
    }

}
