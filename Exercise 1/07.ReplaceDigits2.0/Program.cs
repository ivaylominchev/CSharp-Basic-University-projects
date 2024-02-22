namespace _07.ReplaceDigits2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ch = Console.ReadLine(); 
            for (int i = 0; i < ch.Length; i++)
            {
                int number = int.Parse(ch[i].ToString());
                Console.Write(number + " ");
                for (int j = 0; j < number; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
