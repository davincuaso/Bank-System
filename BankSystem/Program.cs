using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bpi = new Bank();  //create a bank with 2 accounts - Alice and Bob

            bpi.OpenAccount(1200, "Jal");

            bpi.Deposit(200, "Alice"); //deposit 200 to Alice
            bpi.Deposit(700, "Bob"); //deposit 700 to Bob

            Console.WriteLine(bpi.GetBalance("Alice")); //prints Alice balance
            Console.WriteLine(bpi.GetBalance("Bob"));   //prints Bob balance


            Console.ReadLine();
        }
    }
}
