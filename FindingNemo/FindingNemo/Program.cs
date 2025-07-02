namespace FindingNemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindingNemo("I am finding Nemo"));
            Console.WriteLine(FindingNemo("Nemo is me"));
            Console.WriteLine(FindingNemo("Nemo I am"));
            Console.WriteLine(FindingNemo("I am looking for Nemo"));
            Console.WriteLine(FindingNemo("There is no such word here"));
            Console.ReadKey();

        }
        public static string FindingNemo(string sentence) {

            string[] arr = sentence.Split(' ');
            return (arr.Contains("Nemo")) ? $"I found Nemo at {Array.IndexOf(arr, "Nemo") + 1} !" : "I cant find nemo  :(";

        }
    }
}
