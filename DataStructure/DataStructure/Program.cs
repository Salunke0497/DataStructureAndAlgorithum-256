using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BubbleSort");
            BubbleSort sort = new BubbleSort();
            sort.DisplayBubbleSort();

            Console.WriteLine("=================================================");
            Console.WriteLine("=================================================");

            Console.WriteLine("InsertionSort");
            InserSort inserSort = new InserSort();
            inserSort.DisplayInsertionSort();
            Console.ReadLine();
        }
    }
}
