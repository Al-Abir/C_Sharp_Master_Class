using System;
using System.Collections.Generic;
using System.Linq;

// 1. THE DELEGATE (The "Recipe")
// This says: "I can hold any method that takes two ints and returns an int."
public delegate int MathOperation(int a, int b);

class Program
{
    static void Main()
    {
        // 2. THE LAMBDA (The "Implementation")
        // Instead of writing a whole function, we just write the logic inline.
        MathOperation add = (a, b) => a + b;
        MathOperation multiply = (a, b) => a * b;

        // 3. FUNC (The "Built-in" version)
        // You don't even need the delegate above; C# has 'Func' built-in.
        Func<int, int, int> power = (a, b) => (int)Math.Pow(a, b);

        // 4. LINQ (The "Processor")
        var numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Let's use LINQ to square every number in the list.
        // The lambda 'n => n * n' is passed as a Func to the .Select method.
        var squares = numbers.Select(n => n * n);

        Console.WriteLine($"Addition: {add(10, 5)}");      // Output: 15
        Console.WriteLine($"Power: {power(2, 3)}");        // Output: 8
        Console.WriteLine($"Squares: {string.Join(", ", squares)}"); 
    }
}