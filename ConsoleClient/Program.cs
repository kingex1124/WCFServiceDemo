using ConsoleClient.WCFServiceLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IService1 proxy =  new Service1Client();
            string result = proxy.GetData(5);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
