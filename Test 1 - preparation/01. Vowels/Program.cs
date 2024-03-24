namespace _01._Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            int count = 0;
            
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'а' || 
                    word[i] == 'е' || 
                    word[i] == 'и' || 
                    word[i] == 'о' || 
                    word[i] == 'у' || 
                    word[i] == 'ъ' || 
                    word[i] == 'ю' || 
                    word[i] == 'я')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
