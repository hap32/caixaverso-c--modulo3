using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc_notificacao.Interfaces
{
    public interface INotificador
    {
        void Enviar(string mensagem);
    }
}
