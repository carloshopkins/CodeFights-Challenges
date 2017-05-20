using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2_CenturyFromYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindCentury(1710));
            Console.WriteLine(FindCentury(1700));
        }
        public static int FindCentury(int year)
        {
            var century = year / 100;

            if ((year % 100) == 0)
                return century;
            else
                return century + 1;
        }
    }
}
