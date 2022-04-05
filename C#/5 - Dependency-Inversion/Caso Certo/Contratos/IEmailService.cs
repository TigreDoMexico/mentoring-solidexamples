namespace PlataformaDeEnsino.Certo;

public interface IEmailService
{
    void AdicionarDestinatario(string destinatario);
    void AdicionarRemetente(string remetente);
    void Enviar(string assunto, string mensagem);
}