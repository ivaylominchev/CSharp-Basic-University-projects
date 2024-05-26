namespace Task_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число:");
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();
            Stack<char> uniqueStack = new Stack<char>();

            foreach (char digit in input)
            {
                if (!stack.Contains(digit))
                {
                    stack.Push(digit);
                }
            }

            while (stack.Count > 0)
            {
                uniqueStack.Push(stack.Pop());
            }

            char[] resultArray = uniqueStack.ToArray();
            string result = new string(resultArray);

            Console.WriteLine("Резултат след премахване на повтарящите се цифри: " + result);
        }
    }
}
