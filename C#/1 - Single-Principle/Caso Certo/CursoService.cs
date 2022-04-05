using PlataformaDeEnsino.Certo;

public class CursoService
{
    public string AdicionarCurso(Curso curso)
    {
        string errorMessage;
        if(!curso.Validar(out errorMessage))
            return errorMessage;

        var repository = new CursoRepository();
        repository.AdicionarNovoCurso(curso);

        var emailService = new EmailService("empresa@empresa.com", curso.Professor.Email);
        emailService.Enviar("Novo curso atribuido para você", "Bem vindo ao curso");

        return "Curso cadastrado com sucesso";
    }
}