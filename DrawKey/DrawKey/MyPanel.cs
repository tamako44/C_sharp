//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Drawing;

//namespace DrawKey
//{
//    class MyPanel : Panel
//    {
//        protected override void OnPaint(PaintEventArgs e)
//        {
//            base.OnPaint(e);
//            using (Graphics g = e.Graphics)
//            {
//                Rectangle rect = ClientRectangle;
//                rect.Location = new Point(20, 20);                  // specify rectangle relative position here (relative to parent container)
//                rect.Size = new Size(30, 30);                       // specify rectangle size here

//                using (Brush brush = new SolidBrush(Color.Aqua))    // specify color here and brush type here
//                {
//                    g.FillRectangle(brush, rect);
//                }
//            }
//        }
//    }
//}
