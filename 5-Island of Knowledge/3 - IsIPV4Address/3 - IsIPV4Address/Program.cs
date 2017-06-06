using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___IsIPV4Address
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = "172.16.254.1";
            var test2 = "172.316.254.1";
            var test3 = ".254.255.0";

            Console.WriteLine("Expected: True | Result: " + IsIPv4Address(test));
            Console.WriteLine("Expected: False | Result: " + IsIPv4Address(test2));
            Console.WriteLine("Expected: False | Result: " + IsIPv4Address(test3));
        }
        public static bool IsIPv4Address(string inputString)
        {
            string[] arr = inputString.Split('.');
            var x = 0;
            if (arr.Length != 4)
                return false;
            foreach (var i in arr)
            {
                if (Int32.TryParse(i, out x))
                {
                    if (x > 255 || x < 0)
                        return false;
                }
                else
                    return false;
            }
            return true;
        }
    }
}
