using ClientFram.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace ClientFram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebHttpBinding binding = new WebHttpBinding();

            EndpointAddress address = new EndpointAddress("http://localhost:55983/Service1.svc");


            Service1Client client = new Service1Client(binding, address);

            var factory = new ChannelFactory<IService1>(new BasicHttpBinding(), "http://localhost:55983/Service1.svc");
            var proxy = factory.CreateChannel();

            var result = proxy.RegisterEmployee();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
