using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSK
{
    class CreateKey
    {

        public KeyButton[] CreateKeys(string[] TextArr, string[] NameArr, int[] LocaXArr, int[] LocaYArr, int[] SizeX)
        {
            int TotalBtn = TextArr.Length;
            KeyButton[] btn = new KeyButton[TotalBtn];

            for (int a = 0; a < TotalBtn; a++)
            {
                btn[a] = new KeyButton();
                btn[a].Text = TextArr[a];
                btn[a].Name = NameArr[a];
                btn[a].Size = new System.Drawing.Size(SizeX[a], 54);
                btn[a].Location = new System.Drawing.Point(LocaXArr[a], LocaYArr[a]);

            }

            return btn;

        }
    }



}
