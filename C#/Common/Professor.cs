using PlataformaDeEnsino.Certo;

namespace PlataformaDeEnsino.Common;

public class Professor : Usuario
{
    public List<Curso> aulas { get; set; } = new List<Curso>();
}