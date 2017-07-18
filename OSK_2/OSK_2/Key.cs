using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSK_2
{
    class Key
    {
        
        public static void ClickBtn(string KeyCode)
        {
            SendKey(KeyCode);
           // ChangeColor();
           // Display();
        }

        protected static void SendKey(string KeyCode)
        {
            SendKeys.Send(KeyCode);
        }

    }
}
