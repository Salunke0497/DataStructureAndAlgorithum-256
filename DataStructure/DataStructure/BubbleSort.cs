using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class BubbleSort
    {
        //public void DisplayBubbleSort()
        //{
        //    int[] arr = { 78, 55, 45, 98, 13 };
        //    int temp;
        //    for (int j = 0; j <= arr.Length; j++)
        //    {
        //        for (int i = 0; i <= arr.Length; i++)
        //        {
        //            if (arr[i] == arr[i + 1])
        //            {
        //                temp = arr[i + 1];
        //                arr[i + 1] = arr[i];
        //                arr[i] = temp;
        //            }
        //        }
        //    }
        //    Console.WriteLine("sorted : ");
        //    foreach (int p in arr)
        //    {
        //        Console.WriteLine(p);
        //    }
        //}
        public void DisplayBubbleSort()
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap the elements
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            //print array
            foreach (int p in arr)
            {
                Console.WriteLine(p);
            }
        }

    }
}
