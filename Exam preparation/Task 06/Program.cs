namespace Task_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число:");
            int number = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            if (number == 0)
            {
                stack.Push(0);
            }
            else
            {
                while (number > 0)
                {
                    int remainder = number % 2;
                    stack.Push(remainder);
                    number /= 2;
                }
            }

            Console.Write("Двоично представяне: ");
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
