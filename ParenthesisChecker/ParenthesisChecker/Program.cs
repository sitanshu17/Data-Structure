using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParenthesisChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string parenthesis = "{[()]}";
            Program code = new Program();
            bool result = code.ParenthesisChecker(parenthesis);
            if (result)
            {
                Console.WriteLine("Matching Parenthesis.");
            }
            else
            {
                Console.WriteLine("Not Matching Parenthesis.");
            }
            Console.ReadKey();
        }

        public bool ParenthesisChecker(string stringToVerify)
        {

            char[] charArray = stringToVerify.ToCharArray();
            Stack<char> st = new Stack<char>(charArray.Length);

            foreach (char ch in charArray)
            {
                if (ch == '(' || ch == '{' || ch == '{')
                {
                    st.Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == '}')
                {
                    if (st.Count == 0)
                    {
                        return false;
                    }

                    else if (!IsMatching(st.Pop(), ch))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsMatching(char character1, char character2)
        {
            if (character1 == '(' && character2 == ')')
            {
                return true;
            }
            else if (character1 == '[' && character2 == ']')
            {
                return true;
            }
            else if (character1 == '{' && character2 == '}')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
