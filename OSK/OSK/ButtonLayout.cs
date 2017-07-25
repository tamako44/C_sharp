using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

namespace OSK
{
    class ButtonLayout
    {
        protected string[] TextArr;
        protected string[] NameArr;
        protected int[] LocaXArr;
        protected int[] LocaYArr;
        protected int[] SizeXArr;
        protected int[] SizeYArr;

        public KeyButton[] CreateLayout()
        {
            //string[] TextArr, string[] NameArr, int[] LocaXArr, int[] LocaYArr, int[] SizeXArr, int[] SizeYArr
            int TotalBtn = TextArr.Length;
            KeyButton[] btn = new KeyButton[TotalBtn];

            for (int a = 0; a < TotalBtn; a++)
            {
                switch (TextArr[a])
                {
                    case "Switch":
                        btn[a] = new SwitchButton();
                        break;
                    default:
                        btn[a] = new KeyButton();
                        break;
                }
                
                btn[a].Text = TextArr[a];
                btn[a].Name = NameArr[a];
                btn[a].Size = new Size(SizeXArr[a], SizeYArr[a]);
                btn[a].Location = new Point(LocaXArr[a], LocaYArr[a]);
                btn[a].BackColor = Color.DimGray;
                btn[a].ForeColor = Color.White;
            }

            return btn;
        }


        protected internal class Layout1 : ButtonLayout
        {
            protected string[] L1TextArr = new string[] { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "'", "z", "x", "c", "v", "b", "n", "m", ",", ".", "?", "Backspace", "Enter", "↑", "↑", "Ctrl", "&123", "☺", "Space", "<", ">", "Switch" };
            protected string[] L1NameArr = new string[] { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "'", "z", "x", "c", "v", "b", "n", "m", ",", ".", "?", "{BS}", "{ENTER}", "+", "+", "^", " ", " ", " ", "<", ">", " " };
            protected int[] L1LocaXArr = new int[] { 87, 153, 219, 285, 351, 417, 483, 549, 615, 681, 107, 173, 239, 305, 371, 437, 503, 569, 635, 701, 140, 206, 272, 338, 404, 470, 536, 602, 668, 734, 747, 767, 74, 800, 74, 140, 206, 272, 668, 734, 800, 866 };
            protected int[] L1LocaYArr = new int[] { 85, 85, 85, 85, 85, 85, 85, 85, 85, 85, 141, 141, 141, 141, 141, 141, 141, 141, 141, 141, 197, 197, 197, 197, 197, 197, 197, 197, 197, 197, 85, 141, 197, 197, 253, 253, 253, 253, 253, 253, 253 };
            protected int[] L1SizeXArr = new int[] { 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 117, 97, 64, 64, 64, 64, 64, 394, 64, 64, 64 };
            protected int[] L1SizeYArr = new int[] { 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54 };

            public Layout1()
            {
                TextArr = L1TextArr;
                NameArr = L1NameArr;
                LocaXArr = L1LocaXArr;
                LocaYArr = L1LocaYArr;
                SizeXArr = L1SizeXArr;
                SizeYArr = L1SizeYArr;
            }
        }

        protected internal class Layout2 : ButtonLayout
        {

            private string[] L2TextArr = new string[] { "Tab", "!", "@", "#", "$", "%", " & ", "1", "2", "3", "BS", "<", "(", ")", "-", "_", "=", "+", "4", "5", "6", "Enter", ">", "\\", ";", ":", "\"", "*", "/", "7", "8", "9", "&123", "Ctrl", "☺", "<", ">", "Space", "0", ".", "Switch" };
            private string[] L2NameArr = new string[] { "{TAB}", "!", "@", "#", "$", "%", "&", "1", "2", "3", "{BS}", "<", "(", ")", "-", "_", "=", "+", "4", "5", "6", "{ENTER}", ">", "\\", ";", ":", "\"", "*", "/", "7", "8", "9", "&123", "^", "☺", "<", ">", " ", "0", ".", " " };
            private int[] L2LocaXArr = new int[] { 74, 140, 206, 272, 338, 404, 470, 568, 634, 700, 766, 74, 140, 206, 272, 338, 404, 470, 568, 634, 700, 766, 74, 140, 206, 272, 338, 404, 470, 568, 634, 700, 74, 140, 206, 272, 338, 404, 568, 700, 766 };
            private int[] L2LocaYArr = new int[] { 85, 85, 85, 85, 85, 85, 85, 85, 85, 85, 85, 141, 141, 141, 141, 141, 141, 141, 141, 141, 141, 141, 197, 197, 197, 197, 197, 197, 197, 197, 197, 197, 253, 253, 253, 253, 253, 253, 253, 253, 253 };
            private int[] L2SizeXArr = new int[] { 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 132, 132, 64, 64 };
            private int[] L2SizeYArr = new int[] { 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 112, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54 };

            public Layout2()
            {
                TextArr = L2TextArr;
                NameArr = L2NameArr;
                LocaXArr = L2LocaXArr;
                LocaYArr = L2LocaYArr;
                SizeXArr = L2SizeXArr;
                SizeYArr = L2SizeYArr;
            }
        }


    }


  //      public string[] L1AphArr = new string[] { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "'", "z", "x", "c", "v", "b", "n", "m", ",", ".", "?" };
  //      public int[] L1AphLocaXArr = new int[] { 87, 153, 219, 285, 351, 417, 483, 549, 615, 681, 107, 173, 239, 305, 371, 437, 503, 569, 635, 701, 140, 206, 272, 338, 404, 470, 536, 602, 668, 734 };
  //      public int[] L1AphLocaYArr = new int[] { 85, 85, 85, 85, 85, 85, 85, 85, 85, 85, 141, 141, 141, 141, 141, 141, 141, 141, 141, 141, 197, 197, 197, 197, 197, 197, 197, 197, 197, 197, };

		//public string[] L1ModiNameArr = new string[] { "Backspace", "Enter", "↑", "↑", "Ctrl", "&123", "☺", "Space", "<", ">", "Switch" };
  //      string[] L1ModiTextArr = new string[] { "{BS}", "{ENTER}", "+", "+", "^", " ", " ", "<", ">", " " };
  //      public int[] Location_X = new int[] { 747, 767, 74, 800, 74, 140, 206, 272, 668, 734, 800, 866 };
		//public int[] Location_Y = new int[] { 85, 141, 197, 197, 253, 253, 253, 253, 253, 253, 253 };
  //      public int[] L1SizeY = new int[] { 117, 97, 64, 64, 64, 64, 64, 396, 64, 64, 64 };




        //private void Layout_1_Loca()
        //{
        //    int w = 66;
        //    int oh_1 = 87;
        //    int oh_2 = 107;
        //    int oh_3 = 140;
        //    int btnCount = 0;

        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 10; j++)
        //        {
        //            //btn[i] = new Button();
        //            //btn[i].Name = AphArray[btnCount];
        //            //btn[i].Text = btn[i].Name;
        //            //btn[i].Size = new System.Drawing.Size(64, 54);

        //            switch (i)
        //            {
        //                case 0:
        //                    //btn[i].Location = new System.Drawing.Point(oh_1, 85);
        //                    Layout_1_LocaX_Arr[btnCount] = oh_1;
        //                    Layout_1_LocaY_Arr[btnCount] = 85;
        //                    oh_1 += w;
        //                    break;
        //                case 1:
        //                    //btn[i].Location = new System.Drawing.Point(oh_2, 141);
        //                    Layout_1_LocaX_Arr[btnCount] = oh_2;
        //                    Layout_1_LocaY_Arr[btnCount] = 141;
        //                    oh_2 += w;
        //                    break;
        //                default:
        //                    //btn[i].Location = new System.Drawing.Point(oh_3, 197);
        //                    Layout_1_LocaX_Arr[btnCount] = oh_3;
        //                    Layout_1_LocaY_Arr[btnCount] = 197;
        //                    oh_3 += w;
        //                    break;
        //            }

        //            btnCount++;


        //        }
        //    }
        //}



    
}