using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _3_MakeArrayConsecutive2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] statues = {6, 2, 3, 8};
            Console.WriteLine(FindStatues(statues)); 
        }
        public static int FindStatues(int[] statues)
        {
            Array.Sort(statues);
            //min and max variables were not included in the verision submitted on 
            //Codefighters, but I included them here to help improve readability.
            var min = statues[0];
            var max = statues[statues.Length - 1];
            var compareTo = new List<int>();
            
            for (int i = min; i <= max; i++)
            {
                compareTo.Add(i);
            }

            return compareTo.Count - statues.Length;
        }
    }
}
