using PlataformaDeEnsino.Certo;

namespace PlataformaDeEnsino.Common;

public class Aluno : Usuario
{
    public List<Curso> cursos { get; set; } = new List<Curso>();
}