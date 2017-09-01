namespace Defining_Classes_Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            //new dictionary for accounts;
            var accounts = new Dictionary<int, BankAccount>();

            //read the commands;
            string input = "";

            while((input = Console.ReadLine()) != "End")
            {
                //var for splitted input;
                var token = input.Split(' ');

                //var for bank command;
                var bankCommand = token[0];

                switch(bankCommand)
                {
                    case "Create":
                        Create(token, accounts);
                        break;
                    case "Deposit":
                        Deposit(token, accounts);
                        break;
                    case "Withdraw":
                        Withdraw(token, accounts);
                        break;
                    case "Print":
                        Print(token, accounts);
                        break;
                }
            }
        }

        //methnod to print the existing account;
        private static void Print(string[] args, Dictionary<int, BankAccount> accounts)
        {
            //var for id of the account;
            var id = int.Parse(args[1]);

            //check for existing account and print it;
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                Console.WriteLine(accounts[id].ToString());
            }
        }


        //method to withdraw the amount of the existing bank account;
        private static void Withdraw(string[] args, Dictionary<int, BankAccount> accounts)
        {
            //var for id of the account;
            var id = int.Parse(args[1]);
            //var for amount to withdraw;
            var amount = double.Parse(args[2]);

            //check for existing account and withdraw the amount;;
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                if (accounts[id].Balance < amount)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    accounts[id].Withdraw(amount);
                }
            }
        }

        //method to deposit the ammount of the existing bank account;
        private static void Deposit(string[] args, Dictionary<int, BankAccount> accounts)
        {
            //var for id of the account;
            var id = int.Parse(args[1]);
            //var for amount to deposit;
            var amount = double.Parse(args[2]);

            //check for existing account and deposit amount;;
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                accounts[id].Deposit(amount);
            }
        }


        //method to create bank account;
        private static void Create(string[] args, Dictionary<int, BankAccount> accounts)
        {
            //var for ID for the account to be created;
            var id = int.Parse(args[1]);

            //check for existing account or create new one;
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var account = new BankAccount();

                account.ID = id;

                accounts.Add(id, account);
            }
        }
    }   
}
