using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___PalindromeRearranging
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "bbbaaacc";
            var input2 = "aaabbcc";
            Console.WriteLine(PalindromeRearranging(input));
            Console.WriteLine(PalindromeRearranging(input2));
        }
        public static bool PalindromeRearranging(string inputString)
        {
            var arr = inputString.ToCharArray();
            if (inputString.Length == 1)
                return true;
            else if (inputString.Length == 0)
                return false;
            if (inputString.Length % 2 == 0)
            {
                foreach (var i in arr)
                {
                    if ((Array.FindAll(arr, s => s.Equals(i))).Length % 2 != 0)
                        return false;
                }
                return true;
            }
            else
            {
                bool soloCharCheck = false;
                for(var i = 0; i < arr.Length; i++)
                {
                    if ((Array.FindAll(arr, s => s.Equals(arr[i]))).Length % 2 != 0 && !soloCharCheck)
                    {
                        soloCharCheck = true;
                        arr[i] = '-';
                    }
                    else if ((Array.FindAll(arr, s => s.Equals(arr[i]))).Length % 2 != 0 && soloCharCheck)
                        return false;
                }
                return true;
            }
        }

    }
}
