using System.Data;
using System.Data.SqlClient;
using PlataformaDeEnsino.Certo;

public class CursoRepositorioService : ICursoRepositorio
{
    public void adicionaCurso(Curso curso)
    {
        using (var sql = new SqlConnection())
        {
            var command = new SqlCommand();

            sql.ConnectionString = "MinhaConnectionString";
            command.Connection = sql;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO CURSO (NOME, PROFESSOR) VALUES (@nome, @professor))";

            command.Parameters.AddWithValue("nome", curso.Nome);
            command.Parameters.AddWithValue("professor", curso.Professor.Nome);

            sql.Open();
            command.ExecuteNonQuery();
        }
    }
}