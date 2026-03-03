using ioc_notificacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc_notificacao.Infrastructure.Notificadores
{
    public class NotificadorEmail : INotificador
    {
        public void Enviar(string mensagem)
        {
            Console.WriteLine($"EMAIL: {mensagem}");
        }
    }
}
