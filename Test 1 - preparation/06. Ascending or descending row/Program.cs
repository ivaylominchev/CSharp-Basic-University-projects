using System.Globalization;

namespace _06._Ascending_or_descending_row
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prevNumber = int.MinValue;
            int currentNumber = 0;
            bool isAscending = true;
            bool isDescending = true;
            bool firstNumberEntered = false;

            while (true)
            {
                currentNumber = int.Parse(Console.ReadLine());

                if (!firstNumberEntered)
                {
                    prevNumber = currentNumber;
                    firstNumberEntered = true;
                    continue;
                }

                if (currentNumber <= 0)
                {
                    break;
                }

                if (currentNumber > prevNumber)
                {
                    isDescending = false;
                }
                else if (currentNumber < prevNumber)
                {
                    isAscending = false;
                }

                prevNumber = currentNumber;
            }

            if (isAscending && !isDescending)
            {
                Console.WriteLine("The entered numbers form an ascending row.");
            }
            else if (isDescending && !isAscending)
            {
                Console.WriteLine("The entered numbers form a descending row.");
            }
            else
            {
                Console.WriteLine("The entered numbers do not form an ascending or descending sequence.");
            }
        }
    }
}
