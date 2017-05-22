using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CheckPalinprome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckForPalindrome("apple"));
            Console.WriteLine(CheckForPalindrome("aabAa"));
            Console.WriteLine(CheckForPalindrome("racecar"));
            Console.WriteLine(CheckForPalindrome("nope"));
            Console.WriteLine(CheckForPalindrome("ama"));
        }
        public static bool CheckForPalindrome(string input)
        {
            var inputArr = input.ToLower().ToCharArray();
            
            return inputArr.SequenceEqual(inputArr.Reverse());
        }
    }
}
