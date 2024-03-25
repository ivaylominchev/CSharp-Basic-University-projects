namespace _05._Number_of_matches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] numbers = new int[10];
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());
                numbers[i] = newNumber;
            }
            for (int i = 0; i < numbers.Length;i++)
            {
                if (numbers[i] == number)
                {
                    count++;
                }
            }
            if (count > 0)
            {
                Console.WriteLine($"Yes, {number} exists. The number occurs {count} times.");
            }
            else
            {
                Console.WriteLine($"{number} does not exist.");
            }
        }
    }
}
