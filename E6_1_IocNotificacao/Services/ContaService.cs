using ioc_notificacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioc_notificacao.Services
{
    public class ContaService
    {
        private readonly INotificador _notificador;
        public ContaService(INotificador notificador)
        {
            _notificador = notificador;
        }

        public void CriarConta(string nome, string email)
        {
            string mensagem = $"Conta criada para {nome} ({email})";
            _notificador.Enviar(mensagem);
        }
    }
}
