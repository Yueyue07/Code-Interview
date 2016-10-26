using MinStackCode;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExce;

namespace MyStackExce
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack st = new Stack();
            //st.Push('A');
            //st.Push('B');
            //st.Push('C');
            //Console.WriteLine("Current stack: ");
            //foreach (char c in st)
            //{
            //    Console.Write(c + " ");
            //}

            //Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
            //Console.WriteLine("Pop Out This Top Element: {0}", st.Pop());
            //Console.WriteLine("The Rest Available Elements: ");
            //foreach (char c in st)
            //{
            //    Console.Write(c + " ");
            //}

            //var minstack = new MinStack();
            //minstack.Push(18);
            //minstack.Push(19);
            //minstack.Push(29);
            //minstack.Push(15);
            //minstack.Push(16);

            //Console.WriteLine("getmin value: {0}", minstack.GetMin());
            //minstack.Pop();
            //minstack.Pop();
            //minstack.Pop();
            //minstack.Pop();
            //Console.WriteLine("getmin value: {0}", minstack.GetMin());
            //Console.ReadLine();

            Console.WriteLine("Result: {0}", ValidParenthesesExce.IsValid("{"));
            Console.ReadLine();
        }
    }
}
