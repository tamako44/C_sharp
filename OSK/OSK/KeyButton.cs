using System;
using System.Windows.Forms;

namespace OSK
{
    public class KeyButton : Button
    {


        protected override void OnClick(EventArgs e)
        {
            SendKeys.Send(this.Text);
        }
    }
}
