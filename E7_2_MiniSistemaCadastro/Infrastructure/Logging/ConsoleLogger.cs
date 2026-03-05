using E7_2_MiniSistemaCadastro.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7_2_MiniSistemaCadastro.Infrastructure.Logging
{
    public class ConsoleLogger : ILogger 
    { 
        public void Log(string m) => Console.WriteLine($"[LOG]: {m}"); 
    }
}
