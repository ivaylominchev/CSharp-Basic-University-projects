namespace _01._Student_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float gradeSum = 0;
            int studentCount = 0;

            do
            {
                Console.Write("Enter student count: ");
                studentCount = int.Parse(Console.ReadLine());
            }
            while (studentCount < 0);
            
            Student[] students = new Student[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                students[i] = new Student();
                Console.Write("Enter first name: ");
                students[i].FirstName = Console.ReadLine();
                Console.Write("Enter last name: ");
                students[i].LastName = Console.ReadLine();

                bool uniqueFNumber;
                do
                {
                    uniqueFNumber = false;
                    Console.Write("Enter faculty number: ");
                    students[i].FNumber = int.Parse(Console.ReadLine());

                    for (int j = 0; j < i; j++)
                    {
                        if (students[i].FNumber == students[j].FNumber)
                        {
                            uniqueFNumber = true;
                            Console.Write("Faculty number already exists!");
                            break;
                        }
                    }
                }
                while (uniqueFNumber);
                Console.Write("Enter student's grade: ");
                students[i].Grade = float.Parse(Console.ReadLine());
            }

            for (int i = 0;i < studentCount;i++)
            {
                Console.Write($"{students[i].FirstName} {students[i].LastName}, Faculty number: {students[i].FNumber}, Grade: {students[i].Grade}");
                Console.WriteLine();
                gradeSum += students[i].Grade;
            }
            Console.WriteLine($"Average grade: {gradeSum/studentCount:F2}");

            float referenceGrade;
            do
            {
                Console.Write("Reference for student's grade greater than: ");
                referenceGrade = float.Parse(Console.ReadLine());
            }
            while(referenceGrade < 0);

            for (int i = 0; i < studentCount; i++)
            {
                if (students[i].Grade >= referenceGrade)
                {
                    Console.Write($"{students[i].FirstName} {students[i].LastName}, Faculty number: {students[i].FNumber}, Grade: {students[i].Grade}");
                    Console.WriteLine();
                }
            }
        }
    }

    class Person
    {
        public string FirstName, LastName;
    }
    class Student : Person
    {
        public float Grade;
        public int FNumber;
    }
}
