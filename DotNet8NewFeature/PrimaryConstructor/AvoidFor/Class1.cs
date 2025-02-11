using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryConstructor.AvoidFor
{
    #region Custom Property Logic
    //  1. Custom Property Logic (Incorrect)
    /*
    public class User(string Name, int Age)
    {
        // ❌ Cannot validate Age directly inside a Primary Constructor
       // if (Age < 0) throw new ArgumentException("Age cannot be negative");
    }*/

    //  Correct Approach (Traditional Constructor)
    public class User
    {
        public string Name { get; }
        public int Age { get; }

        public User(string name, int age)
        {
            if (age < 0) throw new ArgumentException("Age cannot be negative");
            Name = name;
            Age = age;
        }

        public void Display() => Console.WriteLine($"User: {Name}, Age: {Age}");
    }
    #endregion

    #region  Mutable Fields (Incorrect)
    /*
    public class BankAccount(string AccountNumber, decimal Balance)
    {
        public void Deposit(decimal amount) => Balance += amount; // ❌ Compilation error
    }
    */

    // ✅ Correct Approach (Traditional Constructor with Setter)
    public class BankAccount
    {
        public string AccountNumber { get; }
        public decimal Balance { get; private set; }

        public BankAccount(string accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void DisplayBalance() => Console.WriteLine($"Account: {AccountNumber}, Balance: {Balance:C}");
    }

    #endregion
}
