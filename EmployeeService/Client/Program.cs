using ServiceReference1;
using System;
using System.Threading.Tasks;

namespace Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Service1Client client = new Service1Client();
            var result = await client.RegisterEmployeeAsync();
            Console.WriteLine(result);
        }
    }
}
