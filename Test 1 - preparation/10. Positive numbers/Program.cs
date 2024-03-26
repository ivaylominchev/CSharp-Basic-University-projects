namespace _10._Positive_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < 5; i++)
            {
                int number = int.Parse(Console.ReadLine());
                while (number < 0)
                {
                    Console.WriteLine("Enter positive number!");
                    number = int.Parse(Console.ReadLine());
                }
                if (number >= max)
                {
                    max = number;
                }
                else if (number < min)
                {
                    min = number;
                }
            }

            Console.WriteLine($"Max number: {max}, Min number: {min}");
        }
    }
}
