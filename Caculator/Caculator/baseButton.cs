using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    class BaseButton : Button
    {
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            //Form1 form = new Form1();
            //form.calculateInput(this.Text);
        }
    }
}
