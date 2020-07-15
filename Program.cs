using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build()
                .Run();
        }
    }
}