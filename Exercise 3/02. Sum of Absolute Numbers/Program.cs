namespace _02._Sum_of_Absolute_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size: ");
            int m = int.Parse(Console.ReadLine());
            int[] arr = new int[m];
            int sum = 0;

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Enter number: ");
                arr[i] = int.Parse(Console.ReadLine());
                arr[i] = Math.Abs((int)arr[i]);
                sum += arr[i];
            }
            
            Console.WriteLine("Sum: " + sum);
        }
    }
}
