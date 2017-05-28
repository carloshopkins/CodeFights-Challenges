using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___isLucky
{
    class Program
    {
        static void Main(string[] args)
        {
            var test1 = 472956;
            var test2 = 123321;
            var test3 = 888888;

            Console.WriteLine(IsLucky(test1));
            Console.WriteLine(IsLucky(test2));
            Console.WriteLine(IsLucky(test3));
        }
        public static bool IsLucky(int n)
        {
            char[] digits = n.ToString().ToCharArray();
            var firstSum = 0;
            var secondSum = 0;

            for (var i = 0; i < digits.Length / 2; i++)
            {
                firstSum += int.Parse(digits[i].ToString());
            }

            for (var i = digits.Length / 2; i < digits.Length; i++)
            {
                secondSum += int.Parse(digits[i].ToString());
            }

            return (firstSum == secondSum);
        }

    }
}
