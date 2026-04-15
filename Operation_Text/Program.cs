using System;

class Program
{
    static void Main()
    {
        //  Input String
        string text = "  abir123  ";

        // ================= String Methods =================
        string cleanText = text.Trim();              // space remove
        string upperText = cleanText.ToUpper();      // uppercase

        // ================= Character Methods =================
        char firstChar = cleanText[0];

        bool isLetter = char.IsLetter(firstChar);    // check first char letter?
        bool isDigit = char.IsDigit(cleanText[4]);   // check number

        // ================= String Formatting =================
        Console.WriteLine($"Original Text : '{text}'");
        Console.WriteLine($"Clean Text    : '{cleanText}'");
        Console.WriteLine($"Upper Text    : '{upperText}'");

        Console.WriteLine($"First Char '{firstChar}' is Letter? {isLetter}");
        Console.WriteLine($"Contains Digit at index 4? {isDigit}");
    }
}