﻿using System;
using System.Windows.Forms;
using System.Drawing;

namespace OSK
{
    public class KeyButton : Button
    {
        public bool True { get; private set; }

        protected override void OnClick(EventArgs e)
        {
            SendKeys.Send(this.Name);
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            this.BackColor = Color.Yellow;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            this.BackColor = default(Color);
            //this.BackColor = SystemColors.ButtonFace;
            //this.UseVisualStyleBackColor = True;
        }



    }
}