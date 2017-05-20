using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Add(5, 8);
            Console.WriteLine(result);
        }
        public static int Add(int param1, int param2)
        {
            return param1 + param2;
        }
    }
}
