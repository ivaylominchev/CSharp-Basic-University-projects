namespace _05._Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numebrs = new int[20];
            Random random = new Random();
            for (int i = 0; i < numebrs.Length; i++)
            {
                numebrs[i] = random.Next(-3000, 3000);
            }

            for (int i = 0; i < numebrs.Length; i += 2)
            {
                Console.WriteLine(numebrs[i]);
            }
        }
    }
}
