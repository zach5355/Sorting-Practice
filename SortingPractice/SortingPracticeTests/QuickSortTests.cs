using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SortingPractice;

namespace SortingPractice.Tests
{
    [TestClass()]
    public class QuickSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            int[] arr = new int[] {1,4,9,29,30,2,84,32,10 };
            int[] arrSorted = new int[] { 1,2, 4, 9, 10 ,29, 30, 32, 84};
            QuickSort sort = new QuickSort();
            sort.Sort(arr);

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != arrSorted[i])
                {
                    Assert.Fail();
                }
            }

        }
    }
}