using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator_obj
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.ClientSize = new System.Drawing.Size(624, 792);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion


        private Label lbDisplay;
        State state = new State();
        Calculator calculator;


        private void CreateLabel()
        {
            lbDisplay = new Label();
            this.lbDisplay.Name = "DisplayLabel";
            //this.RightToLeft = RightToLeft.Yes;
            this.lbDisplay.TextAlign = ContentAlignment.BottomRight;
            this.lbDisplay.Font = new Font("Arial", 40);
            this.lbDisplay.Text = "0";
            this.lbDisplay.Size = new Size(263, 100);
            this.lbDisplay.Location = new Point(60, 68);
            this.Controls.Add(lbDisplay);
        }

        private void CreateButton()
        {
            //CreateButton GenButton = new CreateButton();
            //BaseButton[] ButtonArray = GenButton.CreateButtons();
            calculator = new Calculator();
            calculator.state = state; // the first state is the property of calculator
            calculator.updateState = input => lbDisplay.Text = input;

            Button[] ButtonArray = CreateKey();

            foreach (Button key in ButtonArray)
            {
                this.Controls.Add(key);
            }
        }

        methodCheckType checkType = new methodCheckType();

        private string[] TextArr = new string[] { "%", " √ ", "x²", "¹/x", "CE", "C", "←", " ÷ ", "7", "8", "9", "X", "4", "5", "6", "-", "1", "2", "3", "+", "±", "0", ".", "=" };
        private string[] NameArr = new string[] { "percent", "sqrt", "power", "inverse", "CE", "C", "BS", "/", "7", "8", "9", "X", "4", "5", "6", "-", "1", "2", "3", "+", "plus-minus", "0", ".", "=" };
        private int[] LocationXArr = new int[] { 60, 127, 194, 261, 60, 127, 194, 261, 60, 127, 194, 261, 60, 127, 194, 261, 60, 127, 194, 261, 60, 127, 194, 261 };
        private int[] LocationYArr = new int[] { 170, 170, 170, 170, 222, 222, 222, 222, 274, 274, 274, 274, 326, 326, 326, 326, 378, 378, 378, 378, 430, 430, 430, 430 };
        private int[] SizeXArr = new int[] { 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65 };
        private int[] SizeYArr = new int[] { 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 };

        private Button[] CreateKey()
        {
            int TotalBtn = TextArr.Length;
            Button[] btn = new Button[TotalBtn];

            for (int arrayIndex = 0; arrayIndex < TotalBtn; arrayIndex++)
            {
                // total 10 buttons
                if (checkType.isNumber(NameArr[arrayIndex]))
                {
                    numberButton button = new numberButton();
                    button.calculator = calculator;
                    btn[arrayIndex] = button;
                    //btn[arrayIndex].Click += new EventHandler();
                }
                // total 4 buttons
                else if (checkType.isOperator(NameArr[arrayIndex]))
                {
                    btn[arrayIndex] = new operatorButton();
                    //btn[arrayIndex].Click += new EventHandler();
                }
                //total 5 buttons
                else if (checkType.isSpOperator(NameArr[arrayIndex]))
                {
                    btn[arrayIndex] = new spOpButton();
                    //btn[arrayIndex].Click += new EventHandler();
                }
                //total 1 button
                else if (NameArr[arrayIndex] == "=")
                {
                    btn[arrayIndex] = new equalButton();
                    //btn[arrayIndex].Click += new EventHandler();
                }
                //total 1 button
                else if (NameArr[arrayIndex] == "C")
                {
                    btn[arrayIndex] = new CButton();
                    //btn[arrayIndex].Click += new EventHandler();
                }
                //total 1 button
                else if (NameArr[arrayIndex] == "CE")
                {
                    btn[arrayIndex] = new CEButton();
                    //btn[arrayIndex].Click += new EventHandler();
                }
                // total 1 button
                else if (NameArr[arrayIndex] == "BS")
                {
                    btn[arrayIndex] = new BSButton();
                    //btn[arrayIndex].Click += new EventHandler();
                }
                // point
                else if (NameArr[arrayIndex] == ".")
                {
                    btn[arrayIndex] = new pointButton();
                    //btn[arrayIndex].Click += new EventHandler();
                }

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

