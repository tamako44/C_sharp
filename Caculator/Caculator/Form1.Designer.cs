using System.Drawing;
using System.Windows.Forms;

namespace Caculator
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
            this.ClientSize = new System.Drawing.Size(605, 1038);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private void CreateButton()
        {
            CreateButton GenButton = new CreateButton();
            BaseButton[] ButtonArray = GenButton.CreateButtons(); ;

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
    }
}

