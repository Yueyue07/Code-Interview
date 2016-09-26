using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStackExce
{
    public class MyStack<T>
    {
        private T[] _arr;
        private int _tail;

        public MyStack()
        {
            _tail = 0;
            _arr = new T[10];
        }
        public void Push(T data)
        {
            if (_tail == _arr.Length)
            {
                T[] newArray = new T[2 * _arr.Length];
                Array.Copy(_arr, 0, newArray, 0, _tail);
                _arr = newArray;
            }
            _arr[_tail++] = data;
        }

        public T Pop()
        {
            if (_tail == 0) throw new InvalidOperationException("InvalidOperation_EmptyStack");

            T item = _arr[--_tail];
            _arr[_tail] = default(T);
            return item;
        }

        public T Peak()
        {
            if(_tail == 0) throw new InvalidOperationException("InvalidOperation_EmptyStack");
            return _arr[_tail - 1];
        }

    }
}

         

