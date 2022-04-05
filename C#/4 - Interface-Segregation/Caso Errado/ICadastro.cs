namespace PlataformaDeEnsino.Errado;

public interface ICadastro {
    void validarDados();
    void salvarDadosNoBanco();
    void enviarEmail();
}