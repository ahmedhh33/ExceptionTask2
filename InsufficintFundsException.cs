using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTask2
{
    internal class InsufficintFundsException: ApplicationException
    {
        //BankAccount custumer { get; set; }

        public InsufficintFundsException()
        {
            //this.custumer = custumer;
        }

        public override string ToString()
        {
            return $"you do not have sufficiont balace to withdrow ";
        }
    }
}
