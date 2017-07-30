using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSK
{
    public delegate void SFStatusChange(int status);

    public class ShiftButton : KeyButton
    {
        private Panel P1;
        private Panel P2;
        private Panel P3;

        public ShiftButton(Panel Panel1, Panel Panel2, Panel Panel3) : base(Panel1, Panel2, Panel3)
        {
            P1 = Panel1;
            P2 = Panel2;
            P3 = Panel3;
        }

        [Category("自訂屬性")]

        // 0 = no shift, 1 = one click shift, 2 = double click shift; 
        private int _ShiftStatus = 0;
        public int ShiftStatus
        {
            get { return _ShiftStatus; }
            set
            {
                _ShiftStatus = value;
                //if (StatusChange != null)
                    StatusChange(_ShiftStatus);
            }
        }

        public SFStatusChange StatusChange ;


        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (this.ShiftStatus == 0)
            {
                this.ShiftStatus = 1;
            }
            else
            {
                this.ShiftStatus = 0;
            }
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);
            if (this.ShiftStatus == 0)
            {
                this.ShiftStatus = 2;
            }

        }

    }
}
