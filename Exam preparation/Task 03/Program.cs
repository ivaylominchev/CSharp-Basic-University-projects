namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете началната стойност n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Въведете стойността на k: ");
            int k = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);

            List<int> sequence = new List<int>();

            while (sequence.Count < k)
            {
                int current = queue.Dequeue();
                sequence.Add(current);

                queue.Enqueue(current + 1);
                queue.Enqueue(current - 2);
            }

            Console.WriteLine("Редицата е:");
            foreach (int num in sequence)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            if (k <= sequence.Count)
            {
                Console.WriteLine($"Стойността на {k}-тия елемент е: {sequence[k - 1]}");
            }
            else
            {
                Console.WriteLine($"Редицата няма {k} елемента.");
            }
        }
    }
}
