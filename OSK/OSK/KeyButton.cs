using System;
using System.Windows.Forms;
using System.Drawing;

namespace OSK
{
    public class KeyButton : Button
    {
        //private Panel P1;
        //private Panel P2;
        //private Panel P3;

        public KeyButton()
        {
            //P1 = Panel1;
            //P2 = Panel2;
            //P3 = Panel3;
            SetStyle(ControlStyles.StandardClick | ControlStyles.StandardDoubleClick, true);
        }

        private int _ShiftStatus = 0;
        public int ShiftStatus
        {
            get { return _ShiftStatus; }
            set
            {
                _ShiftStatus = value;
            }
        }

        public SFStatusChange StatusChange;

        protected override void OnClick(EventArgs e)
        {
            if (this.ShiftStatus == 1)
            {
                if (this.Name != "Shift")
                {     
                    if (StatusChange != null)
                    {
                        SendKeys.Send(this.Name);
                        StatusChange(0);
                    }
                }
            }
            else
            {
                if (this.Name != "Shift")
                {
                    SendKeys.Send(this.Name);
                }
            }
            base.OnClick(e);
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            //base.OnDoubleClick(e);
            Console.WriteLine("Double");
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
