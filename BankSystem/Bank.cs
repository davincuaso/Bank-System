using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem {
    class Bank {

        //attributes
        const int MAX = 5;
        BankAccount[] accts;
        int numAccts;

        //methods

        //constructor
        public Bank() {        

            //initialize numAccounts to 0

            //instantiate array of BankAccounts
            accts = new BankAccount[MAX];

            //create Alice account and store on index 0
            accts[0] = new BankAccount(1000, "Alice");
            numAccts++;

            //create Bob accounts and store on index 1
            accts[1] = new BankAccount(2000, "Bob");
            numAccts++;


        }

        public void Deposit(double amt, string owner) {

            //find target account
            BankAccount b = FindAccount(owner);

            //perform deposit
            if (b != null)
                b.Deposit(amt);
        }

        public double GetBalance(string owner) {

            //find target account
            BankAccount b = FindAccount(owner);

            if (b != null)
                return b.GetBalance();
            else
                return -1;
        }

        public void Withdraw(double amt, string owner) {

            //find target account
            BankAccount b = FindAccount(owner);

            if (b != null)
                b.Withdraw(amt);
        }
        public BankAccount FindAccount(string owner) 
        {
            BankAccount target = null;

            for(int i = 0; i < numAccts; i++) 
            {
                if (accts[i].GetName() == owner) 
                {
                    target = accts[i];
                    break;
                }
            }

            return target;
        }
    }
}
