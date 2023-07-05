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

            Console.WriteLine("##### Task3 ReadFile #####");
            Console.WriteLine();
            
            Console.Write("Enter the file path: ");
            string filePath = Console.ReadLine();

            StreamReader reader = null;

            try
            {
                reader = new StreamReader(filePath);
                string contents = reader.ReadToEnd();
                Console.WriteLine("File Contents:");
                Console.WriteLine(contents);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while reading the file: " + ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

        }


    }
}