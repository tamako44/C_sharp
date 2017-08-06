//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Drawing;
//using System.Collections;
//using System.Windows.Forms;

//namespace DrawKey
//{
//    //interface IKeyGen
//    //{
//    //    KeyButton[] CreateLayout(Panel Panel1, Panel Panel2, Panel Panel3);
//    //}


//    class ButtonLayout //  : IKeyGen
//    {


//        protected string[] TextArr;
//        protected string[] NameArr;
//        protected int[] LocaXArr;
//        protected int[] LocaYArr;
//        protected int[] SizeXArr;
//        protected int[] SizeYArr;


//        public Graphics CateLayout(MyPanel Panel1)
//        {
//            int TotalBtn = TextArr.Length;
//            Graphics[] btn = Panel1.CreateGraphics();
//            Pen p = new Pen(Color.DimGray);


//            for (int a = 0; a < TotalBtn; a++)
//            {
//                Rectangle key = new Rectangle(SizeXArr[a], SizeYArr[a], SizeXArr[a], SizeYArr[a]);

//                //btn[a].Text = TextArr[a];
//                //btn[a].Name = NameArr[a];
//                //btn[a].Size = new Size(SizeXArr[a], SizeYArr[a]);
//                //btn[a].Location = new Point(LocaXArr[a], LocaYArr[a]);
//                //btn[a].BackColor = Color.DimGray;
//                //btn[a].ForeColor = Color.White;
//            }

//            return btn;
//        }


//        protected internal class Layout1 : ButtonLayout
//        {
//            protected string[] L1TextArr = new string[] { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "'", "z", "x", "c", "v", "b", "n", "m", ",", ".", "?", "Backspace", "Enter", "↑", "↑", "Ctrl", "&123", "☺", "Space", "<", ">", "Switch" };
//            protected string[] L1NameArr = new string[] { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "'", "z", "x", "c", "v", "b", "n", "m", ",", ".", "?", "{BS}", "{ENTER}", "Shift", "Shift", "^", " ", " ", " ", "<", ">", " " };
//            protected int[] L1LocaXArr = new int[] { 87, 153, 219, 285, 351, 417, 483, 549, 615, 681, 107, 173, 239, 305, 371, 437, 503, 569, 635, 701, 140, 206, 272, 338, 404, 470, 536, 602, 668, 734, 747, 767, 74, 800, 74, 140, 206, 272, 668, 734, 800, 866 };
//            protected int[] L1LocaYArr = new int[] { 85, 85, 85, 85, 85, 85, 85, 85, 85, 85, 141, 141, 141, 141, 141, 141, 141, 141, 141, 141, 197, 197, 197, 197, 197, 197, 197, 197, 197, 197, 85, 141, 197, 197, 253, 253, 253, 253, 253, 253, 253 };
//            protected int[] L1SizeXArr = new int[] { 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 117, 97, 64, 64, 64, 64, 64, 394, 64, 64, 64 };
//            protected int[] L1SizeYArr = new int[] { 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54 };

//            public Layout1()
//            {
//                TextArr = L1TextArr;
//                NameArr = L1NameArr;
//                LocaXArr = L1LocaXArr;
//                LocaYArr = L1LocaYArr;
//                SizeXArr = L1SizeXArr;
//                SizeYArr = L1SizeYArr;
//            }
//        }


//        protected internal class Layout2 : ButtonLayout
//        {

//            private string[] L2TextArr = new string[] { "Tab", "!", "@", "#", "$", "%", "'&", "1", "2", "3", "BS", "<", "(", ")", "-", "_", "=", "+", "4", "5", "6", "Enter", ">", "\\", ";", ":", "\"", "*", "/", "7", "8", "9", "&123", "Ctrl", "☺", "<", ">", "Space", "0", ".", "Switch" };
//            private string[] L2NameArr = new string[] { "{TAB}", "!", "@", "#", "$", "%", "&", "1", "2", "3", "{BS}", "<", "(", ")", "-", "_", "=", "+", "4", "5", "6", "{ENTER}", ">", "\\", ";", ":", "\"", "*", "/", "7", "8", "9", "&123", "^", "☺", "<", ">", " ", "0", ".", " " };
//            private int[] L2LocaXArr = new int[] { 74, 140, 206, 272, 338, 404, 470, 568, 634, 700, 766, 74, 140, 206, 272, 338, 404, 470, 568, 634, 700, 766, 74, 140, 206, 272, 338, 404, 470, 568, 634, 700, 74, 140, 206, 272, 338, 404, 568, 700, 766 };
//            private int[] L2LocaYArr = new int[] { 85, 85, 85, 85, 85, 85, 85, 85, 85, 85, 85, 141, 141, 141, 141, 141, 141, 141, 141, 141, 141, 141, 197, 197, 197, 197, 197, 197, 197, 197, 197, 197, 253, 253, 253, 253, 253, 253, 253, 253, 253 };
//            private int[] L2SizeXArr = new int[] { 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 132, 132, 64, 64 };
//            private int[] L2SizeYArr = new int[] { 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 112, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54 };

//            public Layout2()
//            {
//                TextArr = L2TextArr;
//                NameArr = L2NameArr;
//                LocaXArr = L2LocaXArr;
//                LocaYArr = L2LocaYArr;
//                SizeXArr = L2SizeXArr;
//                SizeYArr = L2SizeYArr;
//            }
//        }

//        protected internal class Layout3 : ButtonLayout
//        {
//            protected string[] L3TextArr = new string[] { "Q", "W", "W", "R", "T", "Y", "U", "I", "O", "P", "A", "D", "d", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M" };
//            protected string[] L3NameArr = new string[] { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m" };
//            protected int[] L3LocaXArr = new int[] { 87, 153, 219, 285, 351, 417, 483, 549, 615, 681, 107, 173, 239, 305, 371, 437, 503, 569, 635, 140, 206, 272, 338, 404, 470, 536 };
//            protected int[] L3LocaYArr = new int[] { 85, 85, 85, 85, 85, 85, 85, 85, 85, 85, 141, 141, 141, 141, 141, 141, 141, 141, 141, 197, 197, 197, 197, 197, 197, 197 };
//            protected int[] L3SizeXArr = new int[] { 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64 };
//            protected int[] L3SizeYArr = new int[] { 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54 };

//            public Layout3()
//            {
//                TextArr = L3TextArr;
//                NameArr = L3NameArr;
//                LocaXArr = L3LocaXArr;
//                LocaYArr = L3LocaYArr;
//                SizeXArr = L3SizeXArr;
//                SizeYArr = L3SizeYArr;
//            }
//        }


//    }

//}