using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasVillageHosting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Hosting server = new Hosting();
            server.StartServer();
            Console.WriteLine("Server Started");
            Console.WriteLine("Press any key to stop the Server");
            Console.ReadKey();
            server.StopServer();
            Console.WriteLine("Server Stopped");
        }
    }
}
