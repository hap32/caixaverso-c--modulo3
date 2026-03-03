using ioc_notificacao.Infrastructure.Notificadores;
using ioc_notificacao.Interfaces;
using ioc_notificacao.Services;

class Program
{
    static void Main(string[] args)
    {
        //Email
        INotificador notificadorEmail = new NotificadorEmail();
        ContaService contaEmail = new ContaService(notificadorEmail);
        contaEmail.CriarConta("Henrique", "henrique@caixaverso.com");

        Console.WriteLine("-----");

        //SMS
        INotificador notificadorSms = new NotificadorSms();
        ContaService contaSms = new ContaService(notificadorSms);
        contaSms.CriarConta("Ana", "ana@caixaverso.com");


    }
}
