using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSK
{
    public struct SFBtn
    {
        public bool SFStatus;

        public SFBtn(bool shiftStatus)
        {
            SFStatus = shiftStatus;
        }
    }


    public delegate bool IsShifeMode(SFBtn sfBtn);

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
        private bool _ShiftStatus = false;
        public bool ShiftStatus
        {
            get { return _ShiftStatus; }
            set { _ShiftStatus = value; }
        }

        

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            OneClickLayoutSwitch();   
        }

        void OneClickLayoutSwitch()
        {
            if ( this._ShiftStatus == false)
            {
                this._ShiftStatus = true;
            }
            else
            {
                this._ShiftStatus = true;
            }
            
            //if (P1.Visible == true)
            //{
            //    P1.Visible = false;
            //    P3.Visible = true;
            //}
            //else
            //{
            //    P3.Visible = false;
            //    P1.Visible = true;
            //}
        }

        public void PassShiftStatus(IsShifeMode SFStatus)
        {
            SFStatus(this._ShiftStatus);
        }
    }
}
