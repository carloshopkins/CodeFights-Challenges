using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ShapeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ShapeArea(1));
            Console.WriteLine(ShapeArea(2));
            Console.WriteLine(ShapeArea(3));
            Console.WriteLine(ShapeArea(4));
            Console.WriteLine(ShapeArea(5));
        }
        public static int ShapeArea(int i)
        {
            return 2 * i * (i - 1) + 1;
        }
    }
}
