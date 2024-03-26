using System.Runtime.InteropServices;

namespace _09._Even_or_odd_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countEven = 0;
            int countOdd = 0;
            for (int i = 0; i < 7; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
            }
            if (countEven == 7)
            {
                Console.WriteLine("All numbers are even.");
            }

            if (countOdd == 7)
            {
                Console.WriteLine("All numbers are odd.");
            }
        }
    }
}
