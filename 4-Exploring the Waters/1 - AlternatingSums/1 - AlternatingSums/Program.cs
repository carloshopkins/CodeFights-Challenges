using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___AlternatingSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArr = { 40, 50, 10, 100, 150 };
            int[] testArr2 = { 75, 80, 50, 90, 200, 110 };

            foreach (var i in AlternatingSums(testArr)) 
                Console.Write(i + " ");
            Console.WriteLine();
            foreach (var i in AlternatingSums(testArr2))
                Console.Write(i + " ");
        }
        public static int[] AlternatingSums(int[] a)
        {
            var result = new int[2];
            for (var i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0 || i == 0)
                    result[0] += a[i];
                else
                    result[1] += a[i];
            }
            return result;
        }
    }
}
