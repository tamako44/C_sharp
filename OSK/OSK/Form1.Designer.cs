using System.Windows.Forms;

namespace OSK
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Panel Panel1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 488);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private KeyButton[] AphKeyArr;
       // private KeyButton[] ModiKeyArr;

        private void InitializeKeyboard()
        {
            this.TopMost = true;

            SetPanel1();

            CreateLayoutKey CreateKey = new CreateLayoutKey();
            Layout1 Layout1 = new Layout1();

            AphKeyArr = CreateKey.CreateLayout(Layout1.L1TextArr, Layout1.L1NameArr, Layout1.L1LocaXArr, Layout1.L1LocaYArr, Layout1.L1SizeXArr, Layout1.L1SizeYArr);
            //ModiKeyArr = GenModifyBtn();

            foreach (KeyButton key in AphKeyArr)
            {
                Panel1.Controls.Add(key);
            }



            //         AphKeyArr = GenAphBtn();
            //         ModiKeyArr = GenModifyBtn();

            //         foreach(KeyButton key in AphKeyArr)
            //         {
            //             this.Controls.Add(key);
            //         }

            //foreach (KeyButton key in ModiKeyArr)
            //{
            //	this.Controls.Add(key);
            //}
        }

        private void SetPanel1()
        {
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "panel1";
            this.Panel1.Size = this.ClientSize;
            this.Panel1.TabIndex = 0;
            this.Controls.Add(Panel1);
        }

        private KeyButton[] GenAphBtn()
        {
            KeyButton[] btn = new KeyButton[30];
            int w = 66;
            int oh_1 = 87;
            int oh_2 = 107;
            int oh_3 = 140;
            int btnCount = 0;

            string[] AphArray = new string[] { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "'", "z", "x", "c", "v", "b", "n", "m", ",", ".", "?" };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    btn[btnCount] = new KeyButton();
                    btn[btnCount].Name = AphArray[btnCount]; 
                    btn[btnCount].Text = btn[btnCount].Name;
                    btn[btnCount].Size = new System.Drawing.Size(64, 54);

                    switch (i)
                    {
                        case 0:
                            btn[btnCount].Location = new System.Drawing.Point(oh_1, 85);
                            oh_1 += w;
                            break;
                        case 1:
                            btn[btnCount].Location = new System.Drawing.Point(oh_2, 141);
                            oh_2 += w;
                            break;
                        default:
                            btn[btnCount].Location = new System.Drawing.Point(oh_3, 197);
                            oh_3 += w;
                            break;
                    }
                 
                    this.Controls.Add(btn[btnCount]);
                    btnCount++;
                }
            }
            return btn;
        }

        public KeyButton[] GenModifyBtn()
        {
            KeyButton[] btn = new KeyButton[11];
            //int btnCount = 0;

            string[] ModiNameArr = new string[] { "Backspace", "Enter", "↑", "↑", "Ctrl", "&123", "☺", "Space", "<", ">", "Switch" };
            string[] ModiTextArr = new string[] { "{BS}", "{ENTER}", "+", "+", "^", " ", " ", " ", "<", ">", " " };
            int[] Location_X = new int[] { 747, 767, 74, 800, 74, 140, 206, 272, 668, 734, 800, 866 };
            int[] Location_Y = new int[] { 85, 141, 197, 197, 253, 253, 253, 253, 253, 253, 253 };
            int[] Size_Y = new int[] { 117, 97, 64, 64, 64, 64, 64, 396, 64, 64, 64};

            for (int a = 0; a < 11 ; a ++)
            {
                btn[a] = new KeyButton();
                btn[a].Name = ModiTextArr[a]; //"btn_" + j + "-" + i;
                btn[a].Text = ModiNameArr[a];
                btn[a].Size = new System.Drawing.Size(Size_Y[a], 54);
                btn[a].Location = new System.Drawing.Point(Location_X[a], Location_Y[a]);

                //this.Controls.Add(btn[a]);

            }

            return btn;

        }

    }

}

