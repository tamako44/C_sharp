using System;
using System.Windows.Forms;
using System.Drawing;

namespace OSK
{
    public class KeyButton : Button
    {


        protected override void OnClick(EventArgs e)
        {
            SendKeys.Send(this.Name);
            ChangeKeyColor();
        }

        protected void ChangeKeyColor()
        {
            if (BackColor != Color.Yellow)
                this.BackColor = Color.Yellow;
            else
                ResetBackColor();

        }
    }
}
