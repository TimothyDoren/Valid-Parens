using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Parens
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            bool isValid = false;
            Stack<char> parens = new Stack<char>();
            foreach (char p in s)
            {
                if (p == '(' || p == '[' || p == '{')
                {
                    parens.Push(p);
                }
                else
                {
                    if (parens.Count == 0)
                    {
                        return false;
                    }
                    char first = parens.Pop();
                    if (p == ')' && first != '(' ||
                    p == ']' && first != '[' ||
                    p == '}' && first != '{')
                    {
                        return false;
                    }
                }
            }
            return parens.Count() == 0;
        }
    }
}
