using System;
using Microsoft.AspNetCore.Hosting;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!  The Time is: "+DateTime.Now.ToString());
            var host = new WebHostBuilder()
            .UseKestrel()
            .UseStartup<Startup>()
            .Build();
 
            host.Run();
        }
    }
}
