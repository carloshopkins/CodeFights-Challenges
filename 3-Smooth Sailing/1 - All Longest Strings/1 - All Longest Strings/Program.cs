using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___All_Longest_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] newArr = { "Hellow", "hi", "Iamthelongeststr18" };
            Console.WriteLine(AllLongestStrings(newArr) ); 
        }
        public static string[] AllLongestStrings(string[] inputArray)
        {
            var charCount = 0;
            charCount = inputArray.OrderByDescending(i => i.Length).First().Length;
            return inputArray.Where(i => i.Length == charCount).ToArray();
        }
        

    }
}
