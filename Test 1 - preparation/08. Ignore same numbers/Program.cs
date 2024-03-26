namespace _08._Ignore_same_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int currentNumber = number;
            double average = currentNumber;
            int min = currentNumber;
            
            int count = 1;

            for (int i = 0; i < 9; i++)
            {
                number = int.Parse((Console.ReadLine()));
                if (currentNumber != number)
                {
                    if (number < min)
                    {
                        min = number;
                    }
                    average += number;
                    count++;
                }
                currentNumber = number;
            }
            Console.WriteLine($"Average: {average/count:F2}, Min: {min}");
        }
    }
}
