namespace _04.RemoveChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ch)
                {

                    int index = text.IndexOf(ch);
                    text = text.Remove(index, 1);

                }
            }
            Console.WriteLine(text);
        }
    }
}
