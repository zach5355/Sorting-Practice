using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingPractice
{
    public class QuickSort
    {
        public void Sort(int[]arr)
        {
            QuickSorter(arr,0,arr.Length-1);
        }

        private void QuickSorter(int[] arr,int start,int end)
        {
            if (start >= end)
                return;
            int index = Partition(arr, start, end);
            QuickSorter(arr, start, index - 1);
            QuickSorter(arr, index + 1, end);
        }

        private int Partition(int[] arr, int start, int end)
        {
            int pivot = 0;
            for(int i =0; i < end; i++)
            {
                if(arr[i] < arr[end])
                {
                    Swap(arr, pivot++, i);
                }
            }
            Swap(arr,pivot, end);
            return pivot;
        }
        private void Swap(int[] arr, int first, int second)
        {
            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }
    }
}
