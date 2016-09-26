using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinarySearchExce;


namespace BinarySearchExce
{
    class Program
    {
        static void Main(string[] args)
        {
            var examp1 = new BinarySearch(new int[4] { 1, 3, 5, 6 }, 0);
            Console.WriteLine("Search Result: {0}",examp1.Search());
            Console.ReadLine();
        }
    }
}
