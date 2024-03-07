namespace _01._Array_Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            double average = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out array[i]);
                average += array[i];
            }

            average = Queryable.Average(array.AsQueryable());
            Console.WriteLine(average);
            //average = array.Average();
        }
    }
}
