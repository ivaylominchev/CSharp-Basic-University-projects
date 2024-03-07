namespace _06._Subarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = new int[10];
            int[] secondArr = new int[3];
            Console.WriteLine("Enter first array: ");
            for (int i = 0; i < firstArr.Length; i++)
            {
                firstArr[i] = int.Parse(Console.ReadLine());   
            }
            Console.WriteLine("Enter second array: ");
            for (int i = 0; i < secondArr.Length; i++)
            {
                secondArr[i] = int.Parse(Console.ReadLine());
            }
            
            bool subArr = !secondArr.Except(firstArr).Any();
            Console.WriteLine("Subarray: " + subArr);
        }
    }
}
