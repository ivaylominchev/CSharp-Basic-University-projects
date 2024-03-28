namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                int number = int.Parse(Console.ReadLine());
                while (number < -9 || number > 9)
                {
                    Console.WriteLine("Enter number between -9 and 9!");
                    number = int.Parse(Console.ReadLine());
                }

                array[i] = number;

            }

            Console.WriteLine("The array is: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            for (int i = 0; i < array.Length; i++)
            {
                string concat = array[i].ToString() + "1";
                array[i] = int.Parse(concat);
            }
            Console.WriteLine("The final array is: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
