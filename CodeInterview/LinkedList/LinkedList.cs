using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node<T>
    {
        Node<T> next = null;
        T data;

        public Node (T d)
        {
            this.data = d;
        }

        public void appendToTail(T d)
        {
            Node<T> end = new Node<T>(d);
            Node<T> n = this;

            while (n.next != null) {
                n = n.next;
            }

            n.next = end;
        }
    }
}
  