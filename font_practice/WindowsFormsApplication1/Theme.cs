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

        //public Point Location;
        //public Color Color;
        //public Font Font;
        //public string Text;

        //無法變更
        public Point Location { get; private set; }
        public Color Color { get; private set; }
        public Font Font { get; private set; }
        public String Text { get; private set; }
    }

}
