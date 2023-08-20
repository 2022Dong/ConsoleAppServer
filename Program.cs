using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string address = "net.pipe://localhost/pipemynumbers";
            ServiceHost serviceHost = new ServiceHost(typeof(AstroContract));
            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            serviceHost.AddServiceEndpoint(typeof(IAstroContract), binding, address);
            serviceHost.Open();
            Console.WriteLine("ServiceHost is running. Press <<Return>> to Exit");
            Console.ReadLine(); // Ensure to pause the program during operation.
            serviceHost.Close();
        }
    }
}
