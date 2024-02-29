using System.Runtime.CompilerServices;

namespace _03._Prime_number_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter number");
            int.TryParse(Console.ReadLine(), out number);
            bool check = true;
            if (number == 0 || number == 1)
            {
                check = false;
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    Console.WriteLine($"{number} is prime number");
                }
                else
                {
                    Console.WriteLine($"{number} is not prime number");
                }
            }
        }
    }
}
