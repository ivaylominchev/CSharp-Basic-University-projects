namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число: ");
            string input = Console.ReadLine();
            int[] digitCounts = new int[10];

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    digitCounts[c - '0']++;
                }
            }

            Queue<char> resultQueue = new Queue<char>();

            foreach (char c in input)
            {
                if (char.IsDigit(c) && digitCounts[c - '0'] % 2 != 0)
                {
                    resultQueue.Enqueue(c);
                }
            }

            string result = new string(resultQueue.ToArray());

            Console.WriteLine("Резултат: " + result);
        }
    }
}
