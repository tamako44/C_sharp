using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OSK
{
    class KeyDataPool
    {

        public string[] Layout_1_AphArr = new string[] { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "'", "z", "x", "c", "v", "b", "n", "m", ",", ".", "?" };
        public int[] Layout_1_LocaX_Arr = new int[30];
        public int[] Layout_1_LocaY_Arr = new int[30];

		public string[] ModifyArray = new string[] { "Backspace", "Enter", "↑", "↑", "Ctrl", "&123", "☺", "Space", "<", ">", "Switch" };
		public int[] Location_X = new int[] { 747, 767, 74, 800, 74, 140, 206, 272, 668, 734, 800, 866 };
		public int[] Location_Y = new int[] { 85, 141, 197, 197, 253, 253, 253, 253, 253, 253, 253 };
		public int[] Size_Y = new int[] { 117, 97, 64, 64, 64, 64, 64, 396, 64, 64, 64 };

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
                    //btn[i].Name = AphArray[btnCount]; //"btn_" + j + "-" + i;
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