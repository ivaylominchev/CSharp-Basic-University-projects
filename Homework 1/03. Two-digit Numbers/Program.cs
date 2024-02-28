using Microsoft.VisualBasic;

namespace _03._Two_digit_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());

            

            for (int i = 10; i <= 99 ; i++)
            {
                int firstDigit = i / 10;
                int secondDigit = i % 10;
                

                if (digit == firstDigit || digit == secondDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
