namespace ClassesApp
{
    internal class Customer
    {
        private static int nextID = 0;
        
        private readonly int _id = 0;

        private string _password;

        public string password { set { _password = value; } }



        public int Id
        {
            get { return _id; }
        }
        public string Address { get; set; }
        public string Name { get; set; }
        public int ContactNumber { get; set; }


        public Customer(string name, string address, int contactNumber=0)
        {
            _id = nextID++;
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
        public Customer(string name)
        {
            _id = nextID++;
            Name = name;
        }
        public Customer()
        {
           _id = nextID++;
            Name = "DefaultName";
            Address = "No Address";
            ContactNumber = 0;
        }
        public void setdetails(string name, string address, int contactNumber = 0)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Details about the customer is: Name is {Name} and his id is {_id}");
        }
        public static void CustomerStuff()
        {
            Console.WriteLine("Im doing something");
        }
    }
}
