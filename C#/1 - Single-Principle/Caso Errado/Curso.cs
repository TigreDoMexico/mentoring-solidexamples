namespace PlataformaDeEnsino.Errado;

using PlataformaDeEnsino.Common;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

public class Curso
{
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public Professor Professor { get; set; } = new Professor();

    public string CriarNovoCurso()
    {
        // Validar se os campos estão certos
        if (String.IsNullOrEmpty(Nome))
            return "O curso precisa de um nome";

        // Conexão com o Banco para salvar o Curso
        using (var sql = new SqlConnection())
        {
            var command = new SqlCommand();

            sql.ConnectionString = "MinhaConnectionString";
            command.Connection = sql;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO CURSO (NOME, PROFESSOR) VALUES (@nome, @professor))";

            command.Parameters.AddWithValue("nome", Nome);
            command.Parameters.AddWithValue("professor", Professor.Nome);

            sql.Open();
            command.ExecuteNonQuery();
        }

        // Envio de Email para o Professor
        var mail = new MailMessage("empresa@empresa.com", Professor.Email);
        var client = new SmtpClient
        {
            Port = 25,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Host = "smtp.google.com"
        };

        mail.Subject = "Você tem uma nova disciplina!";
        mail.Body = "Novo Curso Cadastrado";
        client.Send(mail);

        return "Curso cadastrado com sucesso";
    }
}