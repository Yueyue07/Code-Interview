using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinStackCode
{
    public class MinStack
    {
        Stack st;
        Stack stForMin;
        int min;

        public MinStack()
        {
            st = new Stack();
            stForMin = new Stack();
            min = Int32.MaxValue;
        }

        public void Push(int val)
        {
            st.Push(val);
            if (val < min)
            {
                stForMin.Push(val);
                min = val;
            }
        }

        public int Pop()
        {
            if (st.Count == 0)
            {
                throw new System.InvalidOperationException("At the end of Stack, Nothing to Pop ");
            }

            var item = st.Pop();
            if (Convert.ToInt32(item) == min)
            {
                stForMin.Pop();
                min = Convert.ToInt32(stForMin.Peek());
            }

            return Convert.ToInt32(item);

        }

        public int Top()
        {
            if (st.Count == 0)
            {
                throw new System.InvalidOperationException("At the end of Stack, Nothing to Pop ");
            }

            return Convert.ToInt32(st.Peek());

        }

        public int GetMin()
        {
            if (st.Count == 0)
            {
                throw new System.InvalidOperationException("At the end of Stack, Nothing to Pop ");
            }

            return Convert.ToInt32(stForMin.Peek());
        }
    }
}
