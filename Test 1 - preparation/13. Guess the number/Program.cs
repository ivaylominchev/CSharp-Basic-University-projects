namespace _13._Guess_the_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1,50);

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"№{i}: ");
                int guessNumber = int.Parse(Console.ReadLine());
                if (guessNumber < 1 || guessNumber > 50)
                {
                    Console.WriteLine("Out of bounds! Please enter new number between 1 and 50.");
                    guessNumber = int.Parse(Console.ReadLine());
                }

                if (guessNumber == number)
                {
                    Console.WriteLine($"Congratulations, you guessed the number! The random number is {number}.");
                    return;
                }
                else
                {
                    if (i < 5)
                    {
                        Console.WriteLine("Try again!");
                    }
                }
            }
            Console.WriteLine($"Sorry, you did not guess the number. The random number is {number}.");
        }
    }
}
