namespace _03._Reverse_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = Console.ReadLine()
                .Split(",")
                .Select(int.Parse)
                .ToArray();

            var reverseArray = arr.Reverse();
            Console.WriteLine(string.Join(", ", reverseArray));
            
            
        }
    }
}
