namespace _01._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int count= 0;

            foreach (var item in name.ToLower())
            {
                if (item == 'а' 
                    || item == 'е' 
                    || item == 'и' 
                    || item == 'о' 
                    || item == 'у' 
                    || item == 'ъ' 
                    || item == 'ю' 
                    || item == 'я')
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
