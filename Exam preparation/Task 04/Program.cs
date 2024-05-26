namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете началната стойност n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Въведете целевата стойност target: ");
            int target = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);

            List<int> sequence = new List<int>();

            while (sequence.Count < 100)
            {
                int current = queue.Dequeue();
                sequence.Add(current);

                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current);
                queue.Enqueue(current + 2);

                if (sequence.Count >= 100)
                {
                    break;
                }
            }

            Console.WriteLine("Редицата е:");
            for (int i = 0; i < sequence.Count; i++)
            {
                Console.Write(sequence[i] + " ");
            }
            Console.WriteLine();

            if (sequence.Contains(target))
            {
                Console.WriteLine($"Стойността {target} се съдържа сред първите 100 елемента.");
            }
            else
            {
                Console.WriteLine($"Стойността {target} не се съдържа сред първите 100 елемента.");
            }
        }
    }
}
