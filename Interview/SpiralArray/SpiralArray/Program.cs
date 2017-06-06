using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = { new int[] {33,29,-15,-20,-41,-1,34,20,-41,44 },
                            new int[] {14,-11,-27,-35,29,-14,34,-41,49,19 },
                            new int[] {-12,-44,44,-43,-13,-6,40,-24,-6,8 },
                            new int[] {-40,4,27,2,2,15,38,4,-13,15 },
                            new int[] {-42,3,5,10,15,34,-18,-22,9,38 } };
            var res = matrixElementsInSpiralOrder(arr);
            foreach (var i in res)
            {
                Console.WriteLine(i + ", ");
            }
}
        public static int[] matrixElementsInSpiralOrder(int[][] matrix)
        {
            if (matrix.Length < 1)
                return new int[0];

            List<int> result = new List<int>();
            var yMax = matrix.Length - 1;
            var yMin = 0;
            var xMax = matrix[0].Length - 1;
            var xMin = 0;
            result = calculate(matrix, result, xMin, yMin, xMax, yMax);

            while ((matrix.Length) * (matrix[0].Length) > result.Count)
            {
                yMax--;
                yMin++;
                xMax--;
                xMin++;
                result = calculate(matrix, result, xMin, yMin, xMax, yMax);
                Console.WriteLine(result.Count);
            }

            return result.ToArray();
        }
        public static List<int> calculate(int[][] matrix, List<int> result, int xMin, int yMin, int xMax, int yMax)
        {
            //Top row Left => right
            for (var i = xMin; i <= xMax; i++)
            {
                result.Add(matrix[yMin][i]);
            }
            yMin++;

            //Right Column Top => bottom
            for (var i = yMin; i <= yMax; i++)
            {
                result.Add(matrix[i][xMax]);
            }
            xMax--;
            //Check for completion
            if (result.Count == matrix.Length * matrix[0].Length)
                return result;
            //Bottom Row Right => left
            for (var i = xMax; i >= xMin; i--)
            {
                result.Add(matrix[yMax][i]);
            }
            yMax--;

            //Left column Bottom => top
            for (var i = yMax; i >= yMin; i--)
            {
                result.Add(matrix[i][xMin]);
            }
            xMin++;

            return result;
        }
    }
}
