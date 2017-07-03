using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class practice_1
    {
        static void Main(string[] args)
        {
            int[] array_1 = new int[] { 9, 3, 4, 2 };

            int[,] array_2 = new int[2, 2] { { 39, 24 }, { 675, 1 } };

            int[][] array_3 = new int[2][] { new int[] { 3, 2, 1 }, new int[] { 899, 764 } };

            foreach (int i in array_2)
                Console.WriteLine(i);

            //Console.WriteLine(array_3[1][1]);
            Console.ReadLine();

        }
    }
}