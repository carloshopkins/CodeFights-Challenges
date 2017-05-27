using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___CommonCharacterCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var str1 = "aabas";
            var str2 = "ahttabas";

            Console.WriteLine(commonCharacterCount(str1, str2));
        }
        public static int commonCharacterCount(string s1, string s2)
        {
            var result = 0;
            var longer = new List<char>();
            var shorter = new List<char>();
            if (s1.Length > s2.Length)
            {
                longer = s1.ToCharArray().ToList();
                shorter = s2.ToCharArray().ToList();
            }
            else
            {
                longer = s2.ToCharArray().ToList();
                shorter = s1.ToCharArray().ToList();
            }
            for (var i = 0; i < shorter.Count; i++)
            {
                if (longer.Contains(shorter[i]))
                {
                    longer.RemoveAt(longer.IndexOf(shorter[i]));
                    result++;
                }
            }
            return result;
        }
    }
}
