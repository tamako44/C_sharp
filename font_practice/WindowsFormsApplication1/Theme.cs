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
        public Theme(Point location, Color color, Font font, string text)
        {
            this.Location = location;
            this.Color = color;
            this.Font = font;
            this.Text = text;
        }

        public Point Location;
        public Color Color;
        public Font Font;
        public string Text;
    }
}
