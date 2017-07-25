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
            SendKeys.Send(this.Name);
           
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

        //private void Switch_Click(object sender, System.EventArgs e)
        //{
        //    Form_1.Panel1.Visible = false;   
        //}



    }
}
