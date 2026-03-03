using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc_di.Infrastructure.Logging
{
    public class ConsoleLogger : ILogger
    {
        public void Info(string mensagem)
        {
            Console.WriteLine($"[INFO] {mensagem}");
        }

        public void Error(string mensagem)
        {
            Console.WriteLine($"[ERROR] {mensagem}");
        }
    }
}
