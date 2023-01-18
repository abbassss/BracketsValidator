using System.Collections;

namespace PejwakBaran
{
    class Solution
    {

        /// <summary>
        /// This method gets an input string and check if its brackets are valid or not
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsValid( string input)
        {
            Stack stack = new Stack();

            foreach (char currentChar in input.ToCharArray())
            {
                if (currentChar == '(' || currentChar == '{' || currentChar == '[')
                {
                    // Push to stack if it is opening bracket
                    stack.Push(currentChar); 
                }

                // Compare current character with top of stack
                else if ( stack.Count != 0 && currentChar == ')' && (char)stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if ( stack.Count != 0 && currentChar == '}' && (char)stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else if ( stack.Count != 0 && currentChar == ']' && (char)stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else
                {
                    // There is no match character on top of the stack
                    return false;
                }
            }
            return true;
        }
    }
}
