using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Add_Border
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testArr = {"abc", "ded"};
            string[] testArr2 = { "a" };

            foreach (var i in addBorder(testArr))
                Console.WriteLine(i);
            foreach (var i in addBorder(testArr2))
                Console.WriteLine(i); 
        }
        public static string[] addBorder(string[] picture)
        {
            var result = picture.ToList();
            var borderString = "";
            for (var i = 0; i < result.Count; i++)
            {
                result[i] = "*" + result[i] + "*";
            }
            for (var i = 0; i < result[0].Length; i++)
            {
                borderString += "*";
            }
            result.Insert(0, borderString);
            result.Insert(result.Count, borderString);
            return result.ToArray();
        }
    }
}
