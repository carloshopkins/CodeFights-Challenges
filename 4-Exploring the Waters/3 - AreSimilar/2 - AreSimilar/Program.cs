using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___AreSimilar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 3, 9 };
            int[] b = { 10, 3, 2 };

            Console.WriteLine(areSimilar(a, b));
        }
        public static bool areSimilar(int[] a, int[] b)
        {
            var aList = a.ToList();
            var bList = b.ToList();
            for (var i = 0; i < aList.Count; i++)
            {
                if (aList[i] == bList[i])
                {
                    aList.RemoveAt(i);
                    bList.RemoveAt(i);
                    i -= 1;
                }
            }
            if (aList.Count <= 1)
                return true;
            else if (aList.Count > 2)
                return false;
            else if (aList[0] == bList[1] && aList[1] == bList[0])
                return true;
            else
                return false;
        }
    }
}
