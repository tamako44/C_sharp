using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSK
{
    class SwitchButton : KeyButton
    {
        

        private Panel P1;
        private Panel P2;
        private Panel P3;

        public SwitchButton(Panel Panel1, Panel Panel2, Panel Panel3) : base(Panel1, Panel2, Panel3)
        {
            P1 = Panel1;
            P2 = Panel2;
            P3 = Panel3;
        }

        protected override void OnClick(EventArgs e)
        {

            Switch();

        }

        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);
        }


        void Switch()
        {
            if (P1.Visible)
            {
                P1.Visible = false;
                P2.Visible = true;
            }
            else
            {
                P2.Visible = false;
                P1.Visible = true;
            }


        }
    }
}
