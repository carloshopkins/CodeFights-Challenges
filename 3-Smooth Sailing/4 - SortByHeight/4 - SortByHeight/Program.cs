using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___SortByHeight
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArr = { 1, 4, -1, 9, -1 , 100, -1, 8, 11, 19, 3 };

            var resultArr = SortByHeight(testArr);

            foreach (var i in resultArr)
            {
                Console.Write(i + " ");
            }
        }
        public static int[] SortByHeight(int[] a)
        {
            var arr2 = a.Where(i => i != -1).ToList();
            arr2.Sort();
            for (var i = 0; i < a.Length; i++)
            {
                if (a[i] == -1)
                {
                    arr2.Insert(i, -1);
                }
            }
            return arr2.ToArray();
        }
    }
}
