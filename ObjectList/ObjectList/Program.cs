namespace ObjectList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Players> players = new List<Players>();
            players.Add(new Players("Chad"));
            players.Add(new Players("Bharath"));
            players.Add(new Players("Niggalo"));

            foreach(Players player in players)
            {
                Console.WriteLine(player);
            }
            Console.ReadKey();
        }
    }
    class Players
    {
        public string username;

        public Players(string username)
        {
            this.username = username;
        }
        public override string ToString()
        {
            return username;
            
        }
    }
}
