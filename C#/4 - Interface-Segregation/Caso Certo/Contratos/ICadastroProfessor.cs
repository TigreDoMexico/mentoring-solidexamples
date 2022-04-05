namespace PlataformaDeEnsino.Certo;

public interface ICadastroProfessor : ICadastro
{
    void validarDados();
    void enviarEmail();
}