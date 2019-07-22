using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    //http://anh.cs.luc.edu/170/notes/CSharpHtml/sorting

    public class Sorting
    {
        private void Exchange(int[] array, int i, int j)
        {
            int lowest = array[j];
            array[j] = array[i];
            array[i] = lowest;
        }

        public void BubbleSort(int[] array) //O(N²)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                        Exchange(array, i, j);
                }
            }
        }

        public void SelectionSort(int[] array) //O(N)
        {
            int FindSmallestIndex(int[] data, int start)
            {
                int minPos = start;
                for (int pos = start + 1; pos < data.Length; pos++)
                {
                    if (data[pos] < data[minPos])
                        minPos = pos; // Procura o índice do menor valor
                }
                return minPos;
            }

            for (int i = 0; i < array.Length; i++)
            {
                int k = FindSmallestIndex(array, i);
                if (k != i)
                    Exchange(array, i, k);
            }
        }
    }

}
