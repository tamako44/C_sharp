using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OSK
{
    class Layout : IKeyboard
    {

        private KeyButton[] AphKeyArr;
        private KeyButton[] ModiKeyArr;

        void IKeyboard.CreateKey()
        {
            AphKeyArr = GenAphBtn();
            ModiKeyArr = GenModifyBtn();

            foreach (KeyButton key in AphKeyArr)
            {
                this.Controls.Add(key);
            }

            foreach (KeyButton key in ModiKeyArr)
            {
                this.Controls.Add(key);
            }
        }

        public string[] L1AphArr = new string[] { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "'", "z", "x", "c", "v", "b", "n", "m", ",", ".", "?" };
        public int[] L1LocaXArr = new int[] { 87, 153, 219, 285, 351, 417, 483, 549, 615, 681, 107, 173, 239, 305, 371, 437, 503, 569, 635, 701, 140, 206, 272, 338, 404, 470, 536, 602, 668, 734 };
        public int[] L1LocaYArr = new int[] { 85, 85, 85, 85, 85, 85, 85, 85, 85, 85, 141, 141, 141, 141, 141, 141, 141, 141, 141, 141, 197, 197, 197, 197, 197, 197, 197, 197, 197, 197, };

		public string[] L1ModiNameArr = new string[] { "Backspace", "Enter", "↑", "↑", "Ctrl", "&123", "☺", "Space", "<", ">", "Switch" };
        string[] L1ModiTextArr = new string[] { "{BS}", "{ENTER}", "+", "+", "^", " ", " ", "<", ">", " " };
        public int[] Location_X = new int[] { 747, 767, 74, 800, 74, 140, 206, 272, 668, 734, 800, 866 };
		public int[] Location_Y = new int[] { 85, 141, 197, 197, 253, 253, 253, 253, 253, 253, 253 };
        public int[] L1SizeY = new int[] { 117, 97, 64, 64, 64, 64, 64, 396, 64, 64, 64 };

        private void Layout_1_Loca()
        {
            int w = 66;
            int oh_1 = 87;
            int oh_2 = 107;
            int oh_3 = 140;
            int btnCount = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    //btn[i] = new Button();
                    //btn[i].Name = AphArray[btnCount];
                    //btn[i].Text = btn[i].Name;
                    //btn[i].Size = new System.Drawing.Size(64, 54);

                    switch (i)
                    {
                        case 0:
                            //btn[i].Location = new System.Drawing.Point(oh_1, 85);
                            Layout_1_LocaX_Arr[btnCount] = oh_1;
                            Layout_1_LocaY_Arr[btnCount] = 85;
                            oh_1 += w;
                            break;
                        case 1:
                            //btn[i].Location = new System.Drawing.Point(oh_2, 141);
                            Layout_1_LocaX_Arr[btnCount] = oh_2;
                            Layout_1_LocaY_Arr[btnCount] = 141;
                            oh_2 += w;
                            break;
                        default:
                            //btn[i].Location = new System.Drawing.Point(oh_3, 197);
                            Layout_1_LocaX_Arr[btnCount] = oh_3;
                            Layout_1_LocaY_Arr[btnCount] = 197;
                            oh_3 += w;
                            break;
                    }

                    btnCount++;


                }
            }
        }



    }
}