using System;

class Program
{
    static void Main()
    {
        int a = 10;
        int b = 5;

        // Arithmetic
        Console.WriteLine("Add: " + (a + b));

        // Conditional
        if (a > b)
        {
            Console.WriteLine("A is bigger");
        }
        else
        {
            Console.WriteLine("B is bigger");
        }

        int day = 2;

        // ✅ FIXED SWITCH
        switch (day)
        {
            case 1:
                Console.WriteLine("Saturday");
                break;

            case 2:
                Console.WriteLine("Sunday");
                break;

            default:
                Console.WriteLine("Other Day");
                break;
        }

        // Logical
        if (a > 0 && b > 0)
        {
            Console.WriteLine("Both are positive");
        }

        // Bitwise
        Console.WriteLine("Bitwise And: " + (a & b));

        // Loop
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine(i);
        }
    }
}