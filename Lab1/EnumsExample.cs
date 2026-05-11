using System;

namespace BankAccountEnumExample
{
    // Enum for account types
    enum AccountType
    {
        Saving,
        Current,
        Fixed
    }

    // Bank Account class
    class BankAccount
    {
        public string AccountHolder { get; set; }
        public AccountType Type { get; set; }

        // Constructor
        public BankAccount(string name, AccountType type)
        {
            AccountHolder = name;
            Type = type;
        }

        // Display method
        public void Display()
        {
            Console.WriteLine("Account Holder: " + AccountHolder);
            Console.WriteLine("Account Type: " + Type);
        }
    }


}