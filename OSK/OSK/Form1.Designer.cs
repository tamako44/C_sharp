using System;
using System.Windows.Forms;
using static OSK.ButtonLayout;

namespace OSK
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public Panel Panel1;
        public Panel Panel2;
        public Panel Panel3;
        private KeyButton[] KeyArr;

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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 813);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        
       // private KeyButton[] ModiKeyArr;

        private void InitializeKeyboard()
        {
            this.TopMost = true;

            SetPanel1();
            SetPanel2();
            SetPanel3();
            GenLayout1();
            GenLayout2();
            GenLayout3();

        }

        private void SetPanel1()
        {
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "panel1";
            this.Panel1.Size = this.ClientSize;
            this.Panel1.TabIndex = 0;
            this.Panel1.Visible = true;
            this.Controls.Add(Panel1);
        }

        private void SetPanel2()
        {
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Name = "panel2";
            this.Panel2.Size = this.ClientSize;
            this.Panel2.TabIndex = 0;
            this.Panel2.Visible = false;
            this.Controls.Add(Panel2);
        }

        private void SetPanel3()
        {
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Panel3.Location = new System.Drawing.Point(0, 0);
            this.Panel3.Name = "panel3";
            this.Panel3.Size = this.ClientSize;
            this.Panel3.TabIndex = 0;
            this.Panel3.Visible = false;
            this.Controls.Add(Panel3);
        }

        private void GenLayout1()
        {
            ButtonLayout Layout = new Layout1();
            KeyArr = Layout.CreateLayout(Panel1, Panel2, Panel3);

            foreach (KeyButton key in KeyArr)
            {
                Panel1.Controls.Add(key);
                if (key.GetType() == typeof(ShiftButton))
                {
                    ShiftButton button = (ShiftButton) key;
                    button.StatusChange = new SFStatusChange(
                        status =>
                        {
                            Console.WriteLine("delegate");
                            switch (status)
                            {
                                case (0):
                                    this.Panel3.Visible = false;
                                    //this.Panel1.Visible = true;
                                   
                                    break;
                                case (1):
                                    //this.Panel1.Visible = false;
                                    this.Panel3.Visible = true;
                                    break;
                                case (2):
                                   // this.Panel1.Visible = false;
                                    this.Panel3.Visible = true;
                                    break;
                            }

                        });
                }
            }
        }

        private void GenLayout2()
        {
            ButtonLayout Layout = new Layout2();
            KeyArr = Layout.CreateLayout(Panel1, Panel2, Panel3);

            foreach (KeyButton key in KeyArr)
            {
                Panel2.Controls.Add(key);
            }
        }

        private void GenLayout3()
        {
            ButtonLayout Layout = new Layout3();
            KeyArr = Layout.CreateLayout(Panel1, Panel2, Panel3);
            
            //for (int i = 0; i <= 26; i++)
            //{
            //    KeyArr[i].Text = KeyArr[i].Text.ToUpper();
            //    KeyArr[i].Name = KeyArr[i].Name.ToUpper();
            //}
            foreach (KeyButton key in KeyArr)
            {
                Panel3.Controls.Add(key);
                if (key.GetType() == typeof(ShiftButton))
                {
                    ShiftButton button = (ShiftButton)key;
                    button.StatusChange = new SFStatusChange(
                        status =>
                        {
                            Console.WriteLine("delegate");
                            switch (status)
                            {
                                case (0):
                                    this.Panel3.Visible = false;
                                    //this.Panel1.Visible = true;
                                    break;
                                case (1):
                                    //this.Panel1.Visible = false;
                                    this.Panel3.Visible = true;
                                    break;
                                case (2):
                                    //this.Panel1.Visible = false;
                                    this.Panel3.Visible = true;
                                    break;
                            }

                        });
                }
            }
        }









        //private KeyButton[] GenAphBtn()
        //{
        //    KeyButton[] btn = new KeyButton[30];
        //    int w = 66;
        //    int oh_1 = 87;
        //    int oh_2 = 107;
        //    int oh_3 = 140;
        //    int btnCount = 0;

        //    string[] AphArray = new string[] { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "'", "z", "x", "c", "v", "b", "n", "m", ",", ".", "?" };

        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 10; j++)
        //        {
        //            btn[btnCount] = new KeyButton();
        //            btn[btnCount].Name = AphArray[btnCount]; 
        //            btn[btnCount].Text = btn[btnCount].Name;
        //            btn[btnCount].Size = new System.Drawing.Size(64, 54);

        //            switch (i)
        //            {
        //                case 0:
        //                    btn[btnCount].Location = new System.Drawing.Point(oh_1, 85);
        //                    oh_1 += w;
        //                    break;
        //                case 1:
        //                    btn[btnCount].Location = new System.Drawing.Point(oh_2, 141);
        //                    oh_2 += w;
        //                    break;
        //                default:
        //                    btn[btnCount].Location = new System.Drawing.Point(oh_3, 197);
        //                    oh_3 += w;
        //                    break;
        //            }

        //            this.Controls.Add(btn[btnCount]);
        //            btnCount++;
        //        }
        //    }
        //    return btn;
        //}

        //public KeyButton[] GenModifyBtn()
        //{
        //    KeyButton[] btn = new KeyButton[11];
        //    //int btnCount = 0;

        //    string[] ModiNameArr = new string[] { "Backspace", "Enter", "↑", "↑", "Ctrl", "&123", "☺", "Space", "<", ">", "Switch" };
        //    string[] ModiTextArr = new string[] { "{BS}", "{ENTER}", "+", "+", "^", " ", " ", " ", "<", ">", " " };
        //    int[] Location_X = new int[] { 747, 767, 74, 800, 74, 140, 206, 272, 668, 734, 800, 866 };
        //    int[] Location_Y = new int[] { 85, 141, 197, 197, 253, 253, 253, 253, 253, 253, 253 };
        //    int[] Size_Y = new int[] { 117, 97, 64, 64, 64, 64, 64, 396, 64, 64, 64};

        //    for (int a = 0; a < 11 ; a ++)
        //    {
        //        btn[a] = new KeyButton();
        //        btn[a].Name = ModiTextArr[a]; //"btn_" + j + "-" + i;
        //        btn[a].Text = ModiNameArr[a];
        //        btn[a].Size = new System.Drawing.Size(Size_Y[a], 54);
        //        btn[a].Location = new System.Drawing.Point(Location_X[a], Location_Y[a]);

        //        //this.Controls.Add(btn[a]);

        //    }

        //    return btn;

        //}

    }

}

