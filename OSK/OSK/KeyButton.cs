using System;
using System.Windows.Forms;
using System.Drawing;

namespace OSK
{
    public class KeyButton : Button
    {

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            //SendKeys.Send(this.Name);
            string a = this.Text;

            if (this.Name[0] >= 97 && this.Name[0] <= 122)
            {
                SendKeys.Send(a.ToUpper());
            }
            
            else
            {
                SendKeys.Send(this.Name);
            }

        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            this.BackColor = Color.HotPink;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            this.BackColor = Color.DimGray;
        }




    }
}
