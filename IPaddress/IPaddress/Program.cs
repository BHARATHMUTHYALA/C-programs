using System.Net;

namespace IPaddress
{
    internal class Program
    {
       
        
            static void Main(string[] args)
            {
                string hostname = Dns.GetHostName();
                Console.WriteLine("Host name" + hostname);

                var ipAddresses = Dns.GetHostAddresses(hostname);
                foreach (var ip in ipAddresses)
                {
                    Console.WriteLine("IP Address: " + ip);
                }
                Console.ReadKey();
            }
        }
    }

