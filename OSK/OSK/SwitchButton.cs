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
        public SwitchButton(Panel Panel1, Panel Panel2)
        {
            P1 = Panel1;
            P2 = Panel2;
        }

        protected override void OnClick(EventArgs e)
        {

            Switch();
            SendKeys.Send("aaa");

        }

        void Switch()
        {
            SendKeys.Send("ck");

            //Form1 Form1 = new Form1();

            bool PanelStatus = P1.Visible;

            if (PanelStatus == true)
            {
                Console.WriteLine(PanelStatus);
                P1.Visible = false;
                P2.Visible = true;
            }
            else
            {
                Console.WriteLine(PanelStatus);
                P1.Visible = true;
                P2.Visible = false;

            }


        }
    }
}
