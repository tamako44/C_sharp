using System.Windows.Forms;
using System.Drawing;
//using static DrawKey.ButtonLayout;

namespace DrawKey
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Panel Panel1;

        protected string[] TextArr;
        protected string[] NameArr;
        protected int[] LocaXArr;
        protected int[] LocaYArr;
        protected int[] SizeXArr;
        protected int[] SizeYArr;
        protected string[] L1TextArr = new string[] { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "'", "z", "x", "c", "v", "b", "n", "m", ",", ".", "?", "Backspace", "Enter", "↑", "↑", "Ctrl", "&123", "☺", "Space", "<", ">", "Switch" };
        protected string[] L1NameArr = new string[] { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "'", "z", "x", "c", "v", "b", "n", "m", ",", ".", "?", "{BS}", "{ENTER}", "Shift", "Shift", "^", " ", " ", " ", "<", ">", " " };
        protected int[] L1LocaXArr = new int[] { 87, 153, 219, 285, 351, 417, 483, 549, 615, 681, 107, 173, 239, 305, 371, 437, 503, 569, 635, 701, 140, 206, 272, 338, 404, 470, 536, 602, 668, 734, 747, 767, 74, 800, 74, 140, 206, 272, 668, 734, 800, 866 };
        protected int[] L1LocaYArr = new int[] { 85, 85, 85, 85, 85, 85, 85, 85, 85, 85, 141, 141, 141, 141, 141, 141, 141, 141, 141, 141, 197, 197, 197, 197, 197, 197, 197, 197, 197, 197, 85, 141, 197, 197, 253, 253, 253, 253, 253, 253, 253 };
        protected int[] L1SizeXArr = new int[] { 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 117, 97, 64, 64, 64, 64, 64, 394, 64, 64, 64 };
        protected int[] L1SizeYArr = new int[] { 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54 };


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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1352, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 625);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private void DrawTest()
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.DimGray);

            Rectangle key = new Rectangle(87, 85, 64, 54);
            g.DrawRectangle(p, key);

        }

        private void DrawKeys()
        {
            int TotalBtn = L1TextArr.Length;
            Pen p = new Pen(Color.DimGray);
            Font DrawFont = new Font("Arial", 10);
            SolidBrush DrawBrush = new SolidBrush(Color.Black);
            


            for (int a= 0; a < TotalBtn; a++)
            {
                Graphics btn = this.CreateGraphics();
                btn.DrawString(L1TextArr[a], DrawFont, DrawBrush, L1LocaXArr[a], L1LocaYArr[a]);
                Rectangle key = new Rectangle(L1LocaXArr[a], L1LocaYArr[a], L1SizeXArr[a], L1SizeYArr[a]);
                btn.DrawRectangle(p, key);
            }
            
        }

        private Button button1;




        //protected internal class Layout1 : Form1
        //{
        //    protected string[] L1TextArr = new string[] { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "'", "z", "x", "c", "v", "b", "n", "m", ",", ".", "?", "Backspace", "Enter", "↑", "↑", "Ctrl", "&123", "☺", "Space", "<", ">", "Switch" };
        //    protected string[] L1NameArr = new string[] { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "'", "z", "x", "c", "v", "b", "n", "m", ",", ".", "?", "{BS}", "{ENTER}", "Shift", "Shift", "^", " ", " ", " ", "<", ">", " " };
        //    protected int[] L1LocaXArr = new int[] { 87, 153, 219, 285, 351, 417, 483, 549, 615, 681, 107, 173, 239, 305, 371, 437, 503, 569, 635, 701, 140, 206, 272, 338, 404, 470, 536, 602, 668, 734, 747, 767, 74, 800, 74, 140, 206, 272, 668, 734, 800, 866 };
        //    protected int[] L1LocaYArr = new int[] { 85, 85, 85, 85, 85, 85, 85, 85, 85, 85, 141, 141, 141, 141, 141, 141, 141, 141, 141, 141, 197, 197, 197, 197, 197, 197, 197, 197, 197, 197, 85, 141, 197, 197, 253, 253, 253, 253, 253, 253, 253 };
        //    protected int[] L1SizeXArr = new int[] { 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 117, 97, 64, 64, 64, 64, 64, 394, 64, 64, 64 };
        //    protected int[] L1SizeYArr = new int[] { 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54 };

        //    public Layout1()
        //    {
        //        TextArr = L1TextArr;
        //        NameArr = L1NameArr;
        //        LocaXArr = L1LocaXArr;
        //        LocaYArr = L1LocaYArr;
        //        SizeXArr = L1SizeXArr;
        //        SizeYArr = L1SizeYArr;
        //    }
        //}
    }


}

