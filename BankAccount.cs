using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTask2
{
    internal class BankAccount
    {
        public string name { get; set; }
        public int accountNuumber { get; }
        public double balance { get; }
         public BankAccount(string name, int accountNuumber, double balance)
        {
            this.name = name;
            this.accountNuumber = accountNuumber;
            this.balance = balance;
        }

        public double GetBalance() 
        {
            return balance;
        }

        public void withdrowMethod(double amount)
        {
           
                if (amount > balance)
                {
                    throw new InsufficintFundsException();
                }
                Console.WriteLine($" you have after with drowing {balance - amount}");
        }

        public void Withdrow(Double amount)
        {
            try
            {
                withdrowMethod(amount);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                 Console.WriteLine("Do you need to do anuther operation");
            }
        }
    }
}
