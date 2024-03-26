namespace _12._Palindrome_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool check = false;
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] == input[input.Length - 1 - i])
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }

            if (check)
            {
                Console.WriteLine("The string is palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not palindrome.");
            }
        }
    }
}
