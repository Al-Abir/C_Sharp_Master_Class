using System;                     // Built-in Namespace

namespace BankingSystem           // আমাদের নিজস্ব Namespace
{
    // Main Class
    public class BankAccount
    {
        // ==================== Fields (সাধারণত private) ====================
        private readonly int accountNumber;        // readonly field
        private string accountHolder;              
        private decimal balance;                   

        // ==================== const (Compile-time constant) ====================
        public const decimal MinimumBalance = 500;   // সব অ্যাকাউন্টে ন্যূনতম ব্যালেন্স

        // ==================== Auto Properties ====================
        public string AccountType { get; set; }      // Auto Property

        // ==================== Full Property (with logic) ====================
        public string AccountHolder
        {
            get { return accountHolder; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Account holder name cannot be empty!");
                accountHolder = value.Trim();
            }
        }

        // Read-only Property (শুধু get)
        public int AccountNumber
        {
            get { return accountNumber; }
        }

        public decimal Balance
        {
            get { return balance; }
            private set   // শুধুমাত্র ক্লাসের ভিতর থেকে সেট করা যাবে
            {
                if (value < MinimumBalance)
                    throw new InvalidOperationException($"Balance cannot be less than {MinimumBalance} Taka");
                balance = value;
            }
        }

        // ==================== Constructors & Constructor Chaining ====================

        // Default Constructor (Chaining)
        public BankAccount() : this(0, "Unknown", 1000, "Savings")
        {
            Console.WriteLine("Default Constructor called");
        }

        // Parameterized Constructor (Overloading)
        public BankAccount(int accNumber, string holderName, decimal initialBalance, string accType)
        {
            accountNumber = accNumber;           // readonly field শুধু constructor-এ সেট করা যায়
            AccountHolder = holderName;          // Property এর set ব্যবহার হচ্ছে
            AccountType = accType;
            Balance = initialBalance;            // Property এর private set
            Console.WriteLine($"Account {accountNumber} created successfully!");
        }

        // Constructor Overloading - 2nd version (শুধু নাম ও ব্যালেন্স দিয়ে)
        public BankAccount(string holderName, decimal initialBalance)
            : this(GenerateAccountNumber(), holderName, initialBalance, "Savings")
        {
            // এখানে extra logic দিতে পারি
        }

        // ==================== Method Overloading ====================
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive");
            
            Balance += amount;
            Console.WriteLine($"Deposited {amount} Taka. New Balance: {Balance}");
        }

        // Overloaded Method
        public void Deposit(decimal amount, string description)
        {
            Deposit(amount);  // প্রথম মেথডকে কল করা হচ্ছে
            Console.WriteLine($"Note: {description}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdraw amount must be positive");

            if (Balance - amount < MinimumBalance)
                throw new InvalidOperationException("Insufficient balance! Minimum balance must be maintained.");

            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount} Taka. New Balance: {Balance}");
        }

        // Helper method (private)
        private static int GenerateAccountNumber()
        {
            return new Random().Next(100000, 999999);
        }

        // Display method
        public void ShowAccountInfo()
        {
            Console.WriteLine("\n=== Account Information ===");
            Console.WriteLine($"Account Number   : {AccountNumber}");
            Console.WriteLine($"Account Holder   : {AccountHolder}");
            Console.WriteLine($"Account Type     : {AccountType}");
            Console.WriteLine($"Current Balance  : {Balance} Taka");
            Console.WriteLine($"Minimum Balance  : {MinimumBalance} Taka");
        }
    }
}