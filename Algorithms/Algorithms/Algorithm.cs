using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Algorithm
    {
        public int RecursiveFactorial(int number)
        {
            int next = number - 1;
            if (next > 0)
                return number *= RecursiveFactorial(next);
            else
                return number;
        }

        public int DiagonalDifference(int[][] matrix)
        {
            int leftDiagonal = 0;
            int rightDiagonal = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (i == j)
                        leftDiagonal += matrix[i][j];
                    if (i + j == matrix.Length - 1)
                        rightDiagonal += matrix[i][j];
                }
            }

            return Math.Abs(leftDiagonal - rightDiagonal);
        }

        public int[] TripletStupid(int[] alice, int[] bob)
        {
            int[] result = new int[] { 0, 0 };

            for (int i = 0; i < alice.Length; i++)
            {
                if (alice[i] == bob[i])
                    continue;

                if (alice[i] > bob[i])
                    result[0]++;
                else
                    result[1]++;
            }

            return result;
        }

        public int[] OrderAscending(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int lowest = array[j];
                        array[j] = array[i];
                        array[i] = lowest;
                    }
                }
            }

            return array;
        }


        public int[] MinMaxSum(int[] array)
        {
            int[] result = new int[] { 0, 0 };
            OrderAscending(array);

            for (int i = 0; i < array.Length - 1; i++)
                result[0]+=array[i];

            for (int i = 1; i < array.Length; i++)
                result[1]+=array[i];

            return result;
        }
    }
}
