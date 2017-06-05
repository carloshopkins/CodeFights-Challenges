using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___AreEquallyStrong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Expected: True | Result: " + areEquallyStrong(10, 15, 15, 10));
            Console.WriteLine("Expected: True | Result: " + areEquallyStrong(15, 10, 15, 10));
            Console.WriteLine("Expected: False | Result: " + areEquallyStrong(15, 10, 15, 9));
        }
        public static bool areEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
        {
            return (yourLeft == friendsLeft && yourRight == friendsRight || yourLeft == friendsRight && yourRight == friendsLeft);
        }
    }
}
