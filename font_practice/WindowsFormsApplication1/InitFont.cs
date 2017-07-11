using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    public class MyLabel : System.Windows.Forms.Label
    {
        //public Theme theme;
        public Theme theme { get; set; }

        public void ResetAll()
        {
            this.Location = theme.Location;
            this.ForeColor = theme.Color;
            this.Font = theme.Font;
            this.Text = theme.Text; 
        }


    }
}
