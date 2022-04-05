namespace PlataformaDeEnsino.Certo;

public class CursoService
{
    private readonly ICursoRepositorio _repositorio;
    private readonly IEmailService _email;
    private readonly string EMAIL_REMETENTE = "cursos@plataforma.com.br";

    public CursoService(
        ICursoRepositorio repositorio,
        IEmailService email)
        {
            _repositorio = repositorio;
            _email = email;
        }

    public bool AdicionaCurso(Curso curso)
    {
        string errorMessage;
        curso.Validar(out errorMessage);

        if(!string.IsNullOrEmpty(errorMessage))
            throw new Exception(errorMessage);

        _repositorio.adicionaCurso(curso);

        _email.AdicionarDestinatario(curso.Professor.Email);
        _email.AdicionarRemetente(EMAIL_REMETENTE);
        _email.Enviar("Assunto", "Mensagem");

        return true;
    }
}