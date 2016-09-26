using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStackExce
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push('A');
            st.Push('B');
            st.Push('C');
            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
            Console.WriteLine("Pop Out This Top Element: {0}", st.Pop());
            Console.WriteLine("The Rest Available Elements: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.ReadLine();
        }
    }
}
