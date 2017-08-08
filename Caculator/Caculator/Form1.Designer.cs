using System.Drawing;
using System.Windows.Forms;
using System;

namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Label DisplayLabel;

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
            this.ClientSize = new System.Drawing.Size(599, 935);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private void CreateButton()
        {
            //CreateButton GenButton = new CreateButton();
            //BaseButton[] ButtonArray = GenButton.CreateButtons();
            BaseButton[] ButtonArray = CreateKey();

            foreach (BaseButton key in ButtonArray)
            {
                this.Controls.Add(key);
            }
        }

        private void CreateLabel()
        {
            DisplayLabel = new Label();
            this.DisplayLabel.Name = "DisplayLabel";
            //this.RightToLeft = RightToLeft.Yes;
            this.DisplayLabel.TextAlign = ContentAlignment.BottomRight;
            this.DisplayLabel.Font = new Font("Arial", 40);
            this.DisplayLabel.Text = "0";
            this.DisplayLabel.Size = new Size(263, 100);
            this.DisplayLabel.Location = new Point(60, 68);
            this.Controls.Add(DisplayLabel);
        }

        private string[] TextArr = new string[] { "%", " √ ", "x²", "¹/x", "CE", "C", "←", " ÷ ", "7", "8", "9", "X", "4", "5", "6", "-", "1", "2", "3", "+", "±", "0", ".", "=" };
        private string[] NameArr = new string[] { "percent", "radical sign", "power", "integral", "CE", "C", "delete", "/", "7", "8", "9", "X", "4", "5", "6", "-", "1", "2", "3", "+", "plus-minus", "0", ".", "=" };
        private int[] LocationXArr = new int[] { 60, 127, 194, 261, 60, 127, 194, 261, 60, 127, 194, 261, 60, 127, 194, 261, 60, 127, 194, 261, 60, 127, 194, 261 };
        private int[] LocationYArr = new int[] { 170, 170, 170, 170, 222, 222, 222, 222, 274, 274, 274, 274, 326, 326, 326, 326, 378, 378, 378, 378, 430, 430, 430, 430 };
        private int[] SizeXArr = new int[] { 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65 };
        private int[] SizeYArr = new int[] { 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 };


        private BaseButton[] CreateKey()
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
                btn[arrayIndex].Click += new EventHandler(calculate);
                //btn[arrayIndex].BackColor = Color.DimGray;
            }

            return btn;
        }
    }
}

