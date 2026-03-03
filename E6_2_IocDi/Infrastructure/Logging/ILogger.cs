using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc_di.Infrastructure.Logging
{
    public interface ILogger
    {
        void Info(string mensagem);
        void Error(string mensagem);
    }
}
