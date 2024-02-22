namespace _05.FromulaMatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int x = 1; x <= n; x++)
            {
                for (int y = 1; y <= n; y++)
                {
                    for (int z = 1; z <= n; z++)
                    {
                        if (x * x + y * y == z * z * z)
                        {
                            Console.WriteLine($"{x}^2+{y}^2={z}^3");
                        }
                    }
                }
            }
        }
    }
}
