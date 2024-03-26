namespace _11._Same_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sameNumber = n;
            int count = 0;
            while (sameNumber == n)
            {
                n = int.Parse(Console.ReadLine());
                count++;
            }
            Console.WriteLine($"{sameNumber} - {count} times");
        }
    }
}
