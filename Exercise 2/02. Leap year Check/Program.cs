using System.Timers;

namespace _02._Leap_year_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine($"{year} is Leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not Leap year");
            }
        }
        
    }
}
