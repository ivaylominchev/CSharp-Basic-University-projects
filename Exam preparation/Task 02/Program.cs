namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Queue<int> queue = new Queue<int>();

            int numberOfElements = 20;

            for (int i = 0; i < numberOfElements; i++)
            {
                int randomNumber = random.Next(-10, 11);
                queue.Enqueue(randomNumber);
            }

            Console.WriteLine("Елементите в опашката:");
            foreach (int num in queue)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            List<int> positiveNumbers = new List<int>();

            while (queue.Count > 0 && positiveNumbers.Count < 5)
            {
                int current = queue.Dequeue();
                if (current > 0)
                {
                    positiveNumbers.Add(current);
                }
            }

            if (positiveNumbers.Count > 0)
            {
                Console.WriteLine("Първите 5 положителни числа са:");
                foreach (int num in positiveNumbers)
                {
                    Console.Write(num + " ");
                }
            }
            else
            {
                Console.WriteLine("Няма положителни числа в опашката.");
            }
        }
    }
}
