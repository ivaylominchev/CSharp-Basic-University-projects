namespace _01._Algorithm_for_Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=0; int b=0; int c=0;
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            int.TryParse(Console.ReadLine(), out c);

            decimal average = (a + b + c) / 3;

            Console.WriteLine($"{average:f2}");
        }
    }
}
