namespace _03._Prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            if (number == 0 || number == 1)
            {
                Console.WriteLine(number + " is not prime number");
                return;
            }
            for (int i = 1; i <= number/2; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine($"{number} is not prime number");
                    return;
                }
                else
                {
                    Console.WriteLine($"{number} is prime number");
                }
            }
            /*if (number == 0 || number == 1)
            {
                Console.WriteLine($"{number} is not prime number");
            }
            else
            {
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine(number + " is not prime number");
                        return;
                    }
                }
                Console.WriteLine($"{number} is prime number");
            }*/
        }
    }
}
