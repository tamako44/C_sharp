    using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CreateButton
    {
        private string[] TextArr = new string[] { "%", " √ ", "x²", "¹/x", "CE", "C", "←", " ÷ ", "7", "8", "9", "×", "4", "5", "6", "-", "1", "2", "3", "+", "±", "0", ".", "=" };
        private string[] NameArr = new string[] { "percent", "sqrt", "power", "integral", "CE", "C", "delete", "divide", "7", "8", "9", "time", "4", "5", "6", "subtract", "1", "2", "3", "add", "plus-minus", "0", "point", "equal" };
        private int[] LocationXArr = new int[] { 60, 127, 194, 261, 60, 127, 194, 261, 60, 127, 194, 261, 60, 127, 194, 261, 60, 127, 194, 261, 60, 127, 194, 261 };
        private int[] LocationYArr = new int[] { 170, 170, 170, 170, 222, 222, 222, 222, 274, 274, 274, 274, 326, 326, 326, 326, 378, 378, 378, 378, 430, 430, 430, 430 };
        private int[] SizeXArr = new int[] { 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65 };
        private int[] SizeYArr = new int[] { 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 };

        public BaseButton[] CreateButtons()
        {
            int TotalBtn = TextArr.Length;
            BaseButton[] btn = new BaseButton[TotalBtn];

            for (int arrayIndex = 0; arrayIndex < TotalBtn; arrayIndex++)
            {
                btn[arrayIndex] = new BaseButton();
                btn[arrayIndex].Text = TextArr[arrayIndex];
                btn[arrayIndex].Name = NameArr[arrayIndex];
                btn[arrayIndex].Size = new Size(SizeXArr[arrayIndex], SizeYArr[arrayIndex]);
                btn[arrayIndex].Location = new Point(LocationXArr[arrayIndex], LocationYArr[arrayIndex]);
                //btn[arrayIndex].BackColor = Color.DimGray;
            }

            return btn;
        }
    }
}
