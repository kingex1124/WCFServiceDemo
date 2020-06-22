using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibraryDemo;

namespace ConsoleAppWCFService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Service is running...");
            ServiceHost myHost = new ServiceHost(typeof(Service1));
            myHost.Open();
            Console.ReadLine();
        }
    }
}
