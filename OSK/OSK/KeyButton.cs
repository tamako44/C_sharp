using System;
using System.Windows.Forms;
using System.Drawing;

namespace OSK
{
    public class KeyButton : Button
    {
        private Panel P1;
        private Panel P2;
        private Panel P3;

        public KeyButton(Panel Panel1, Panel Panel2, Panel Panel3)
        {
            P1 = Panel1;
            P2 = Panel2;
            P3 = Panel3;
        }


        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            if (P3.Visible == true)
            {
                if (this.Name != "Shift")
                {
                    SendKeys.Send(this.Name);
                    P3.Visible = false;
                    P1.Visible = true;
                }       
            }
            else
            {
                if (this.Name != "Shift")
                {
                    SendKeys.Send(this.Name);
                }
            }

            //string a = this.Text;

            //if (this.Name[0] >= 97 && this.Name[0] <= 122)
            //{
            //    SendKeys.Send(a.ToUpper());
            //}
            
            //else
            //{
            //    SendKeys.Send(this.Name);
            //}

        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            this.BackColor = Color.HotPink;
            this.ForeColor = Color.DimGray;
            
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            this.BackColor = Color.DimGray;
            this.ForeColor = Color.White;
        }

        protected override void OnMouseHover(EventArgs e)
        {

            this.BackColor = Color.White;
            this.ForeColor = Color.DimGray;
            base.OnMouseHover(e);

        }

        protected override void OnMouseLeave(EventArgs e)
        {

            this.BackColor = Color.DimGray;
            this.ForeColor = Color.White;
            base.OnMouseHover(e);
        }




    }
}
