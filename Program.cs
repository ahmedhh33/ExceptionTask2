namespace ExceptionTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##### Task1 BankAccount #####");
            BankAccount customer = new BankAccount("salim",2233232,223);
            customer.Withdrow(32);
            Console.WriteLine();
            customer.Withdrow(500);
            Console.WriteLine("##### Task2 ClassRoom #####");
            ClassRoom Class1 = new ClassRoom("Calculas1", "Tariq");
            Class1.registrationStudent3(34);
            Console.WriteLine();
            Class1.registrationStudent3(55);

        }


    }
}