namespace Task_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            Stack<int> evenStack = new Stack<int>();
            Stack<int> oddStack = new Stack<int>();

            while (queue.Count > 0)
            {
                int number = queue.Dequeue();
                if (number % 2 == 0)
                {
                    evenStack.Push(number);
                }
                else
                {
                    oddStack.Push(number);
                }
            }

            Console.WriteLine("Четни стойности в стека:");
            while (evenStack.Count > 0)
            {
                Console.WriteLine(evenStack.Pop());
            }

            Console.WriteLine("Нечетни стойности в стека:");
            while (oddStack.Count > 0)
            {
                Console.WriteLine(oddStack.Pop());
            }
        }
    }
}
