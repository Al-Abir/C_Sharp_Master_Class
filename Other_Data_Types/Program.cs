using System;
using System.Text;


    // 🔹 Struct
    struct Point
    {
        public int X;
        public int Y;
    }

    // 🔹 Enum
    enum Day
    {
        Saturday,
        Sunday,
        Monday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 🔹 Struct use
            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine($"Struct: {p.X}, {p.Y}");

            // 🔹 Enum use
            Day today = Day.Sunday;
            Console.WriteLine($"Enum: {today}");

            // 🔹 DateTime
            DateTime now = DateTime.Now;
            Console.WriteLine($"DateTime: {now}");

            // 🔹 StringBuilder
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append(" World");
            Console.WriteLine($"StringBuilder: {sb}");

            // 🔹 Parameter Modifiers
            int num = 5;
            AddTen(ref num);
            Console.WriteLine($"ref: {num}");

            GetValues(out int a, out int b);
            Console.WriteLine($"out: {a}, {b}");

            int sum = Sum(1, 2, 3);
            Console.WriteLine($"params: {sum}");

            // 🔹 Tuple
            var person = GetUser();
            Console.WriteLine($"Tuple: {person.Name}, {person.Age}");

            // 🔹 Nullable
            int? number = null;
            Console.WriteLine($"Nullable: {number ?? 0}");

            // 🔹 Anonymous Object
            var student = new { Name = "Hridoy", Age = 22 };
            Console.WriteLine($"Anonymous: {student.Name}");

            // 🔹 dynamic
            dynamic data = "Hello";
            Console.WriteLine($"Dynamic: {data.Length}");
            data = 100;
            Console.WriteLine($"Dynamic: {data + 50}");
        }

        // 🔹 ref
        static void AddTen(ref int x)
        {
            x += 10;
        }

        // 🔹 out
        static void GetValues(out int a, out int b)
        {
            a = 5;
            b = 10;
        }

        // 🔹 params
        static int Sum(params int[] numbers)
        {
            int total = 0;
            foreach (var n in numbers)
                total += n;
            return total;
        }

        // 🔹 Tuple return
        static (string Name, int Age) GetUser()
        {
            return ("Hridoy", 22);
        }
    }
