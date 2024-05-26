namespace Task_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете израз:");
            string input = Console.ReadLine();

            input = input.ToLower();
            string cleanedInput = "";
            foreach (char c in input)
            {
                if (char.IsLetterOrDigit(c))
                {
                    cleanedInput += c;
                }
            }

            Stack<char> stack = new Stack<char>();
            int length = cleanedInput.Length;
            int halfLength = length / 2;

            for (int i = 0; i < halfLength; i++)
            {
                stack.Push(cleanedInput[i]);
            }

            int start = (length % 2 == 0) ? halfLength : halfLength + 1;

            bool isPalindrome = true;
            for (int i = start; i < length; i++)
            {
                if (stack.Pop() != cleanedInput[i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("Изразът е палиндром.");
            }
            else
            {
                Console.WriteLine("Изразът не е палиндром.");
            }
        }
    }
}
