using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Startup");
            var log = new LoggerConfiguration()
                .WriteTo.RollingFile("log-{Date}.txt")
                .CreateLogger();

            while(true)
            {
                log.Information(DateTime.Now.ToLongDateString());
                Task.Delay(2000);
            }

            Console.Read();
        }
    }
}
