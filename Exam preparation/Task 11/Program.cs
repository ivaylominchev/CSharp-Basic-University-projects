namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Примерна редица
            int[] array = { 34, 3, 31, 98, 92, 23 };

            // Извеждаме оригиналната редица
            Console.WriteLine("Оригинална редица:");
            PrintArray(array);

            // Сортираме редицата с помощта на опашка
            int[] sortedArray = SortUsingQueue(array);

            // Извеждаме сортираната редица
            Console.WriteLine("Сортирана редица:");
            PrintArray(sortedArray);
        }

        static int[] SortUsingQueue(int[] array)
        {
            Queue<int> queue = new Queue<int>(array);
            List<int> sortedList = new List<int>();

            while (queue.Count > 0)
            {
                // Намерете минималния елемент в опашката
                int min = int.MaxValue;
                int n = queue.Count;

                for (int i = 0; i < n; i++)
                {
                    int value = queue.Dequeue();
                    if (value < min)
                    {
                        min = value;
                    }
                    queue.Enqueue(value);
                }

                // Извадете всички елементи, които са равни на минималния, и ги добавете към сортираната листа
                for (int i = 0; i < n; i++)
                {
                    int value = queue.Dequeue();
                    if (value != min)
                    {
                        queue.Enqueue(value);
                    }
                    else
                    {
                        sortedList.Add(value);
                    }
                }
            }

            return sortedList.ToArray();
        }

        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
