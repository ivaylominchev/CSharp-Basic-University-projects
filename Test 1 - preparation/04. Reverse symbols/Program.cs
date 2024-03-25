namespace _04._Reverse_symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string words = string.Empty;
            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                words += symbol;
            }
            Console.WriteLine(string.Join(" ",words.Reverse()));
        }
    }
}
