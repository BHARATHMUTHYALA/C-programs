namespace ClassesApp
{
    internal class Program  
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Customer customer2 = new Customer("john doe");

            customer.GetDetails();
            customer2.GetDetails();
            Console.WriteLine("cUSTOMER 2 ID IS"+customer2.Id);
            customer2.password = "12312";
            //Console.WriteLine(customer2.password);
            Console.ReadKey();

        }
    }
}   