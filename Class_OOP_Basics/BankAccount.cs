
using System;

namespace BankingSystem
{
    
    public class BankAccount
    {

        // ==================== Fields (সাধারণত private) ====================
        private readonly int accountNumber; // readOnly Field
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

    }

}