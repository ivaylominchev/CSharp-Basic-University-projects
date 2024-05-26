namespace Task_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете израз със скоби:");
            string input = Console.ReadLine();

            if (AreBracketsBalanced(input))
            {
                Console.WriteLine("Скобите са правилно поставени.");
            }
            else
            {
                Console.WriteLine("Скобите не са правилно поставени.");
            }
        }

        static bool AreBracketsBalanced(string expression)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in expression)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char openBracket = stack.Pop();

                    if (!IsMatchingPair(openBracket, ch))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        static bool IsMatchingPair(char openBracket, char closeBracket)
        {
            return (openBracket == '(' && closeBracket == ')') ||
                   (openBracket == '{' && closeBracket == '}') ||
                   (openBracket == '[' && closeBracket == ']');
        }
    }
}
