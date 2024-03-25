namespace _03._Two_digit_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 10; i < 100; i++)
            {
                int firstDigit = i / 10;
                int lastDigit = i % 10;
                
                if (number == firstDigit || number == lastDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
