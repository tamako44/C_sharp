using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OSK
{
    interface IKeyboard
    {
        void CreateLayout();
    }

    class CreateLayoutKey
    {

        public KeyButton[] CreateLayout(string[] TextArr, string[] NameArr, int[] LocaXArr, int[] LocaYArr, int[] SizeXArr, int[] SizeYArr)
        {
            int TotalBtn = TextArr.Length;
            KeyButton[] btn = new KeyButton[TotalBtn];

            for (int a = 0; a < TotalBtn; a++)
            {
                btn[a] = new KeyButton();
                btn[a].Text = TextArr[a];
                btn[a].Name = NameArr[a];
                btn[a].Size = new System.Drawing.Size(SizeXArr[a], SizeYArr[a]);
                btn[a].Location = new System.Drawing.Point(LocaXArr[a], LocaYArr[a]);
                btn[a].BackColor = Color.DimGray;
                btn[a].ForeColor = Color.White;
            }

            return btn;

        }

        class CreateLayoutDraw
        {
            
        }
    }



}
