using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StackExce
{
    public class ReversePolishNotation
    {
        public int EvalRPN(string[] tokens)
        {
            var charArray = tokens.ToCharArray();
            Stack st = new Stack();
            int index = 0;
            while (index < charArray.Length)
            {
                if (charArray[index] == '+' || charArray[index] == '-' || charArray[index] == '*' || charArray[index] == '/')
                {
                    var Value1 = Convert.ToInt32(st.Pop());
                    var Value2 = Convert.ToInt32(st.Pop());
                    switch (charArray[index])
                    {
                        case '+':
                            st.Push(Value2 + Value1);
                            break;
                        case '-':
                            st.Push(Value2 - Value1);
                            break;
                        case '/':
                            st.Push(Value2 / Value1);
                            break;
                        case '*':
                            st.Push(Value2 * Value1);
                            break;
                    }

                }
                else
                {
                    st.Push(Convert.ToInt32(charArray[index]));
                }

                index++;
            }

            return st.Pop();
        }
    }
}
