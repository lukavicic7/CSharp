using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba1
{
    class Zad3
    {
        //Štednja , Tekući račun, Žiro račun
        public struct BankAccount
        {
            //broj računa, iznos na računu i vrstu računa.

            public int AccountNumber;
            public double AccountAmount;
            public AccountTypes AccountType;
            public BankAccount(int Account_Number, double Account_Amount, AccountTypes Account_Type)
            {
                AccountNumber = Account_Number;
                AccountAmount = Account_Amount;
                AccountType = Account_Type;
            }
            // te  napraviti izbornik  koji će  imati  opcije, 
            //upisa  novog  računa,  i  ispis  svih  računa.  Za  ispis  svih računa koristiti “foreach” iteraciju.

        }
        public enum AccountTypes
        {
            Savings,
            CurrentAccount,
            GiroAccount
        }
        public static void PrintAccounts(List<BankAccount> accounts)
        {
            foreach (BankAccount b in accounts)
            {
                Console.WriteLine("Account number: " + b.AccountAmount + "\nAccount amount: " + b.AccountAmount + "\nAccountType: " + b.AccountType);
            }
        }

        public static BankAccount NewBankAccount(){
            
            Console.WriteLine("Unesite broj računa: ");
            int broj = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesite iznos računa: ");
            double iznos = Convert.ToDouble(Console.ReadLine());
            AccountTypes acc;
            Console.WriteLine("Unesite vrstu računa: ");
            Console.WriteLine("\n0 - Štednja");
            Console.WriteLine("\n1 - Tekući račun");
            Console.WriteLine("\n2 - Žiro račun");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                acc = AccountTypes.Savings;
            }
            else if (a == 1)
            {
                acc = AccountTypes.CurrentAccount;
            }
            else if (a == 2)
            {
                acc = AccountTypes.GiroAccount;
            }
            else
            {
                acc = AccountTypes.CurrentAccount;
            }

            return new BankAccount(broj, iznos, acc);
        }

        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>
            {
                new BankAccount(1,522.5,AccountTypes.CurrentAccount),
                new BankAccount(2,780.55,AccountTypes.CurrentAccount),
                new BankAccount(3,570.44,AccountTypes.CurrentAccount),
                new BankAccount(4,123.56,AccountTypes.CurrentAccount),
                new BankAccount(5,500,AccountTypes.CurrentAccount)
            }; 
            
            string s;
            while (true)
            {
                Console.WriteLine("You are in main menu - choose action:");
                Console.WriteLine("1 - Insert new account");
                Console.WriteLine("2 - Print all accounts");
                Console.WriteLine("Q - Exit");

                s = Console.ReadLine();

                if (s == "1")
                {
                    accounts.Add(NewBankAccount());
                }
                else if (s == "2")
                {
                    PrintAccounts(accounts);
                }
                else if (s == "q")
                {
                    break;
                }
            }
        }
    }
}

