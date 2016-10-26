using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StackExce
{
   public static class ValidParenthesesExce
    {
        public static bool IsValid(string s)
        {
            var charArr = s.ToCharArray();
            Stack st = new Stack();
            Dictionary<char, char> D = new Dictionary<char, char>()
            {
                {')', '('},
                {'}', '{'},
                {']', '['}
            };
            foreach (char item in charArr)
            {
                if (item == '(' || item == '{' || item == '[')
                {
                    st.Push(item);
                }
                else if (item == ')' || item == ']' || item == '}')
                {
                    if (st.Count == 0) return false;
                    if (D[item] != Convert.ToChar(st.Pop()))
                    {
                        return false;
                    }
                }
            }
            return st.Count == 0 ? true : false;

        }
    }
}
