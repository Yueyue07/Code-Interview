using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayExce;

namespace ArrayExce
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] result =  Exce1.MergeSortedArray(new int[6] { 1, 2, 3, 4, 5, 12}
              , new int[5] { 3, 6, 7, 9, 10 });
            foreach (int item in result)
            {
                Console.WriteLine("Merge Sort Array Result: {0}", item);
            }
            Console.ReadLine();
        }
    }
}
