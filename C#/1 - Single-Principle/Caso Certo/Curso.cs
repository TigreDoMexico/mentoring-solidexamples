namespace PlataformaDeEnsino.Certo;

using PlataformaDeEnsino.Common;

public class Curso
{
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public Professor Professor { get; set; } = new Professor();

    public bool Validar(out string errorMessage)
    {
        errorMessage = "";

        if (String.IsNullOrEmpty(Nome))
            errorMessage = "Nome não pode ser vazio";

        return errorMessage.Length > 0;
    }
}