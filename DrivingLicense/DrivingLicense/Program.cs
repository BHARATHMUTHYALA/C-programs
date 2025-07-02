namespace DrivingLicense
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(License("Eric", 2, "Adam Caroline Nigga Kojja"));
            Console.ReadKey();
            
        }
    
    
        public static int License(string me, int agents, string others)
        {
            string[] names = (me + " " + others).Split(' ');
            Array.Sort(names);

            int position = Array.IndexOf(names, me) + 1;
            int TimeToProceess = ((position - 1) / agents) * 20 + 20;

            return TimeToProceess;
        }
        
    }
}
