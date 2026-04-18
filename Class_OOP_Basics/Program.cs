using System;
using BankingSystem;   // আমাদের Namespace import

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Welcome to Banking System ===\n");

        // 1. Default Constructor
        BankAccount acc1 = new BankAccount();

        // 2. Parameterized Constructor with chaining
        BankAccount acc2 = new BankAccount("হৃদয় রহমান", 5000);

        // 3. Full Constructor
        BankAccount acc3 = new BankAccount(123456, "আলী আহমেদ", 15000, "Current");

        acc2.ShowAccountInfo();

        // Method Overloading ব্যবহার
        acc2.Deposit(3000);
        acc2.Deposit(2000, "Salary Credit");

        try
        {
            acc2.Withdraw(8000);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        acc2.ShowAccountInfo();

        // const ব্যবহার দেখানো
        Console.WriteLine($"\nBank Minimum Balance Rule: {BankAccount.MinimumBalance} Taka");

        Console.ReadKey();
    }
}