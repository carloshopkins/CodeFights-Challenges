using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_MatrixElementsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[][] newMatrix = new int[][] { new int[]  { 0, 1, 1, 2},
                                              new int[]  { 0, 5, 0, 0},
                                              new int[]  { 2, 0, 3, 3 } };
            //newMatrix[0, 0] = 0;
            //newMatrix[0, 1] = 1;
            //newMatrix[0, 2] = 1;
            //newMatrix[0, 3] = 2;

            //newMatrix[1, 0] = 0;
            //newMatrix[1, 1] = 5;
            //newMatrix[1, 2] = 0;
            //newMatrix[1, 3] = 0;

            //newMatrix[2, 0] = 2;
            //newMatrix[2, 1] = 0;
            //newMatrix[2, 2] = 3;
            //newMatrix[2, 3] = 3;

            /*
             [[0,1,1,2], 
             [0,5,0,0], 
             [2,0,3,3]]         
             */
            Console.WriteLine(newMatrix[0][3]);
            //Console.WriteLine(MatrixElementsSum(newMatrix));
        }
        public static int MatrixElementsSum(int[][] matrix)
        {
            var total = 0;
            var hauntedFloors = new List<int>();
            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = 0; j < matrix[i].Length; j++)
                {
                    if (hauntedFloors.Contains(j))
                    {
                        break;
                    }
                    else {
                        if (matrix[i][j] == 0)
                        {
                            hauntedFloors.Add(j);
                        }
                        else
                        {
                            if (i == 0)
                            {
                                total += matrix[i][j];
                            }
                            else
                            {
                                if (matrix[i - 1][j] != 0)
                                {
                                    total += matrix[i][j];
                                }
                            }
                        }
                    }
                }
            }
            return total;
        }
    }
}
