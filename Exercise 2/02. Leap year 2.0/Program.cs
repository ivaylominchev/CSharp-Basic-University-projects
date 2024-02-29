namespace _02._Leap_year_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Въведете година: ");
            int.TryParse(Console.ReadLine(), out year);
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} е високосна");
            }
            else
            {
                Console.WriteLine($"{year} не е високосна");
            }
        }
    }
}
