namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[3, 3]; 
            for (int i = 0; i < A.GetLength(0); i++) 
            { 
                for (int j = 0; j < A.GetLength(1); j++) 
                { Console.Write($"A[{i},{j}]="); 
                    int.TryParse(Console.ReadLine(), out A[i, j]); 
                } 
            }
            int sum = 0; 
            int count = 0; 
            foreach (int element in A) 
            {
                if (element > 0)
                {
                    sum += element;
                    count++;
                } 
            }
            Console.WriteLine("Average is {0:0.00}", (decimal)sum/count);
        }
    }
}
