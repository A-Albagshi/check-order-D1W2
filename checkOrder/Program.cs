using System;
using System.Collections.Generic;

namespace checkOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string case1 = "123321";   // true
            string case2 = "11223443"; // true
            string case3 = "11223454543"; // false
            string case4 = "1122345543"; // true
            string case5 = ""; // false
            string case6 = "1414"; // false

            Console.WriteLine(checkOrder(case1));
            Console.WriteLine(checkOrder(case2));
            Console.WriteLine(checkOrder(case3));
            Console.WriteLine(checkOrder(case4));
            Console.WriteLine(checkOrder(case5));
            Console.WriteLine(checkOrder(case6));
        }

        static bool checkOrder(string source)
        {
            if (source.Length % 2 != 0 || source.Length == 0 || source == null) return false;
            Stack <char> chStack = new Stack <char>();

            for (int i = 0; i < source.Length; i++)
            {
                if (chStack.Count == 0 || source[i] != chStack.Peek())
                {
                    chStack.Push(source[i]);
                }
                else
                {
                    chStack.Pop();
                }
            }
            if (chStack.Count == 0)
            {
                return true;
            }
            return false;

        }
    }
}
