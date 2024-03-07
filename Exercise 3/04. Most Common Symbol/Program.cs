using System.Collections.Specialized;
using System.Data;

namespace _04._Most_Common_Symbol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = new char[20];
            int[] count = new int[256];
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = char.Parse(Console.ReadLine());
            }

            /*int maxCount = -1;
            char character = ' ';
           
            for (int i = 0; i < chars.Length; i++)
            {
                if (maxCount < count[chars[i]])
                {
                    maxCount = count[chars[i]];
                    character = chars[i];
                }
            }
            Console.WriteLine(character);*/
            Console.WriteLine(MostAparitionsChar(chars));
        }
        public static char MostAparitionsChar(char[] chars)
        {
            return chars.GroupBy(x => x)
                 .OrderByDescending(x => x.Count())
                 .Select(g => g.Key)
                 .First();
        }
    }
}
