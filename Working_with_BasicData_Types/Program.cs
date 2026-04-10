using System;

class Program
{
    static void Main()
    {
        // =========================
        // 1. DATA TYPES & VARIABLES
        // =========================
        int age = 25;                 // integer
        double salary = 45000.50;     // floating number
        char grade = 'A';             // character
        bool isActive = true;         // boolean
        string name = "Hridoy";      // string

        // Constant
        const double PI = 3.1416;

        // using var (compiler decides type automatically)
        var city = "Dhaka";
        var marks = 85;

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Salary: " + salary);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Active: " + isActive);
        Console.WriteLine("City: " + city);
        Console.WriteLine("Marks: " + marks);
        Console.WriteLine("PI: " + PI);

        Console.WriteLine("\n=========================\n");

        // =========================
        // 2. ARRAY
        // =========================
        int[] numbers = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Array Elements:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine("\n=========================\n");

        // =========================
        // 3. MULTIDIMENSIONAL ARRAY
        // =========================
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("2D Array (Matrix):");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n=========================\n");

        // =========================
        // 4. JAGGED ARRAY
        // =========================
        int[][] jagged = new int[3][];

        jagged[0] = new int[] { 1, 2 };
        jagged[1] = new int[] { 3, 4, 5 };
        jagged[2] = new int[] { 6, 7, 8, 9 };

        Console.WriteLine("Jagged Array:");
        for (int i = 0; i < jagged.Length; i++)
        {
            for (int j = 0; j < jagged[i].Length; j++)
            {
                Console.Write(jagged[i][j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n=========================\n");

        // =========================
        // 5. INPUT / OUTPUT
        // =========================
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        Console.Write("Enter your age: ");
        int userAge = int.Parse(Console.ReadLine());

        Console.WriteLine("Hello " + userName + ", you are " + userAge + " years old.");
    }
}