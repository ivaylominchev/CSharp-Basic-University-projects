namespace _06.ReplaceDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                int lastnumber = n % 10;
                Console.Write(lastnumber + " ");
                for (int j = 0; j < lastnumber; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
                n /= 10;
            }
        }
    }
}
