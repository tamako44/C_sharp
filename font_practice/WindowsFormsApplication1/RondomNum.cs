using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1;

namespace MathCalculate
{ 
    public class RondomNum
    {
        public static int get_rnd_size()
        {
            Random rnd_size = new Random();
            int size = rnd_size.Next(10, 60);
            return size;
        }

        public static int get_rnd_location()
        {
            Random rnd_location = new Random();
            int location = rnd_location.Next(255, 420);
            return location;
        }
    }



}

