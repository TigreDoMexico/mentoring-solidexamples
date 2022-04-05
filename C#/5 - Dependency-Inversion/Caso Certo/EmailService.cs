using System.Net.Mail;
using PlataformaDeEnsino.Certo;

public class EmailServico : IEmailService
{
    public string Remetente { get; set; } = "";
    public string Destinatario { get; set; } = "";

    public EmailServico(string de, string para)
    {
        Remetente = de;
        Destinatario = para;
    }

    public void AdicionarDestinatario(string destinatario) =>
        Destinatario = destinatario;

    public void AdicionarRemetente(string remetente) =>
        Remetente = remetente;

    public void Enviar(string assunto, string mensagem)
    {
        var mail = new MailMessage(Remetente, Destinatario);
        var client = new SmtpClient
        {
            Port = 25,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Host = "smtp.google.com"
        };

        mail.Subject = assunto;
        mail.Body = mensagem;
        client.Send(mail);
    }
}