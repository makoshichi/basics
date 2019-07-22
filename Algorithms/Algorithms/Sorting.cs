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
        private void Swap(int[] array, int i, int j)
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
                        Swap(array, i, j);
                }
            }
        }

        public void SelectionSort(int[] array) //O(N²); less comparisons (comparison time is non-trivial)
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
                    Swap(array, i, k);
            }
        }

        public void MergeSort(int[] array, int p, int r)
        {
            int q = (int)Math.Floor((double)((p + r) / 2));

            if (q == p)
                return;

            if (array[q] < array[p]) {
                Swap(array, q, p);
                r = p;
            }
            else
            {
                Swap(array, p, q);
                p = q;
            }
            MergeSort(array, q, r);
            MergeSort(array, p, q + 1);
        }

        //public void QuickSort
    }

}
