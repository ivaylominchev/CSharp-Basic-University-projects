namespace _07._Contains_digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string companyName = string.Empty;
            string names = string.Empty;
            for (int i = 0; i < 5; i++)
            {
                companyName = Console.ReadLine();
                if (companyName.Any(char.IsDigit))
                {
                    names += companyName + " ";
                }
            }

            Console.WriteLine(string.Join("",names));
        }
    }
}
