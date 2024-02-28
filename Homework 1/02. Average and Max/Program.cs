namespace _02._Average_and_Max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double average = 0;
            int max = int.MinValue;
            double count = 0;
            
            while (number != 0)
            {
                average += number;
                if (number > max)
                {
                    max = number;
                }
                count++;
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(average/count);
            Console.WriteLine(max);
        }
    }
}
