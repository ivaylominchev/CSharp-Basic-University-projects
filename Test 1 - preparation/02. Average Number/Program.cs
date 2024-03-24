namespace _02._Average_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double average = 0;
            int max = int.MinValue;
            int count = 0;
            while (n != 0)
            {
                average += n;
                if (n > max)
                {
                    max = n;
                }
                count++;
                n= int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Average number: {average/count:F2} Max number: {max}");
        }
    }
}
