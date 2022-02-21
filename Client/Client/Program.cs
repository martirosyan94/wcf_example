using ServiceReference1;
using System;
using System.ServiceModel;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
      
WebHttpBinding binding = new WebHttpBinding();

EndpointAddress address = new EndpointAddress("http://localhost:55983/Service1.svc");


            Service1Client client = new Service1Client(binding, address);
            var result = await client.RegisterEmployeeAsync();
            Console.WriteLine(result);
        }
    }
}
