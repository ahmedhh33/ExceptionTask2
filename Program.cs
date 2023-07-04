namespace ExceptionTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount customer = new BankAccount("salim",2233232,223);
            customer.Withdrow(32);
        }
    }
}