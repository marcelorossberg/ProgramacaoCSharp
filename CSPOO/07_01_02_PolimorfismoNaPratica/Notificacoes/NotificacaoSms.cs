namespace Notificacoes
{
    public class NotificacaoSms : Notificacao
    {
        public NotificacaoSms(string destinatario, string mensagem) : base(destinatario, mensagem)
        {
        }

        public override void Enviar()
        {
            Console.WriteLine($"Enviando sms para {Destinatario} com a mensagem '{Mensagem}'.");
        }
    }
}