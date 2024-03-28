namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {

                Console.Write("Enter dimensionality of the matrix (number between 2 and 10): ");
                n = int.Parse(Console.ReadLine());
            } while (n < 2 || n > 10);

            int[,] matrix = new int[n, n];

            Console.WriteLine("Enter matrix elements: ");
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                }
            }

            Console.WriteLine("Matrix:");
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[] minAbsValues = new int[n];
            int minAbs = 0;
            int absValue = 0;
            for (int i = 0; i < n; i++)
            {
                minAbs = Math.Abs(matrix[i, 0]);
                for (int j = 1; j < n; j++)
                {
                    absValue = Math.Abs(matrix[i, j]);
                    if (absValue < minAbs)
                    {
                        minAbs = absValue;
                    }
                }
                minAbsValues[i] = minAbs;
            }

            Console.WriteLine("The smallest absolute value of each row: ");
            for (int i = 0; i < minAbsValues.Length; i++)
            {
                Console.Write(minAbsValues[i] + " ");
            }
        }
    }
}
