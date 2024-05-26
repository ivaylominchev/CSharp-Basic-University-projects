namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 34, 3, 31, 98, 92, 23 };

            Console.WriteLine("Оригинална редица:");
            PrintArray(array);

            int[] sortedArray = SortUsingStacks(array);

            Console.WriteLine("Сортирана редица:");
            PrintArray(sortedArray);
        }

        static int[] SortUsingStacks(int[] array)
        {
            Stack<int> inputStack = new Stack<int>(array);
            Stack<int> tempStack = new Stack<int>();

            while (inputStack.Count > 0)
            {
                int current = inputStack.Pop();

                while (tempStack.Count > 0 && tempStack.Peek() > current)
                {
                    inputStack.Push(tempStack.Pop());
                }

                tempStack.Push(current);
            }

            int[] sortedArray = tempStack.ToArray();

            return sortedArray;
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
