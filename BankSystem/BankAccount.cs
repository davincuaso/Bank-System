using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class BankAccount
    {
        //define attributes
        double balance;
        string name;

        //define methods

        //define constructor for initialization of attributes
        public BankAccount()
        {
            balance = 1000;
        }

        //define constructor than initializes attributes from external classes
        public BankAccount(double initBalance, string owner) 
        {
            balance = initBalance;
            name = owner;
        }

        //Deposit method
        public void Deposit(double amt)
        {
            balance = balance + amt;
        }

        //Get Balance method
        public double GetBalance()
        {
            return balance;
        }

        public void Withdraw(double amt)
        {
            if (IsValid(amt))
                balance = balance - amt;
        }

        public bool IsValid(double amt) 
        {
            return (amt <= balance);       
        }

        public string GetName() 
        {
            return name;
        }
    }
}
