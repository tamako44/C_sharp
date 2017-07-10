using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public struct Theme
    {
        public Theme(Point location, Color color, Font font)
        {
            this.location = location;
            this.color = color;
            this.font = font;
        }

        public Point location;
        public Color color;
        public Font font;
    }
}
