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
        public KeyButton[] KeyLayout1;
        public KeyButton[] KeyLayout2;
        public KeyButton[] KeyLayout3;

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
            KeyLayout1 = Layout.CreateLayout(Panel1, Panel2, Panel3);

            foreach (KeyButton key in KeyLayout1)
            {
                Panel1.Controls.Add(key);
                if (key.GetType() == typeof(ShiftButton))
                {
                    ShiftButton button = (ShiftButton) key;
                    button.StatusChange += SFSwitch;
                }
            }
        }

        private void GenLayout2()
        {
            ButtonLayout Layout = new Layout2();
            KeyLayout2 = Layout.CreateLayout(Panel1, Panel2, Panel3);

            foreach (KeyButton key in KeyLayout2)
            {
                Panel2.Controls.Add(key);
            }
        }

        private void GenLayout3()
        {
            ButtonLayout Layout = new Layout1();
            KeyLayout3 = Layout.CreateLayout(Panel1, Panel2, Panel3);

            for (int i = 0; i <= 26; i++)
            {
                KeyLayout3[i].Text = KeyLayout3[i].Text.ToUpper();
                KeyLayout3[i].Name = KeyLayout3[i].Name.ToUpper();
            }
            //foreach (KeyButton key in KeyLayout3)
            //{
            //    Panel3.Controls.Add(key);
            //    if (key.GetType() == typeof(ShiftButton))
            //    {1
            //        ShiftButton button = (ShiftButton)key;
            //        button.StatusChange += SFSwitch;
            //    }
            //}
        }

        private void SFSwitch(int status)
        {
            //Console.WriteLine("delegate");

            foreach (KeyButton key in KeyLayout1)
            {
                if (key.GetType() == typeof(ShiftButton))
                {
                    ShiftButton button = (ShiftButton)key;
                    button.ShiftStatus = status;
                }

            }
            foreach (KeyButton key in KeyLayout2)
            {
                if (key.GetType() == typeof(ShiftButton))
                {
                    ShiftButton button = (ShiftButton)key;
                    button.ShiftStatus = status;
                }

            }
            foreach (KeyButton key in KeyLayout3)
            {
                if (key.GetType() == typeof(ShiftButton))
                {
                    ShiftButton button = (ShiftButton)key;
                    button.ShiftStatus = status;
                }

            }

            switch (status)
            {
                case (0):
                    this.Panel3.Visible = false;
                    this.Panel1.Visible = true;                   
                    break;
                case (1):
                    this.Panel1.Visible = false;
                    this.Panel3.Visible = true;
                    break;
                case (2):
                    this.Panel1.Visible = false;
                    this.Panel3.Visible = true;
                    break;
            }
        }
    }

}

