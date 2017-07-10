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

        public Theme theme;
        

        public void ResetAll()
        {
            
            ResetText();


            this.Location = theme.location;
            this.ForeColor = theme.color; 
        }


    }
}
