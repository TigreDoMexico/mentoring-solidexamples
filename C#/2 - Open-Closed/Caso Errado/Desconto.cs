namespace PlataformaDeEnsino.Errado;

using Certo = PlataformaDeEnsino.Certo;
using PlataformaDeEnsino.Common;

public class Desconto
{
    public void InserirDesconto(int valor, Certo.Curso curso, Usuario usuario)
    {
        if(usuario is Professor)
        {
            // Regra para aplicar desconto
        }

        if(usuario is Aluno)
        {
            // Regra para aplicar desconto
        }
    }
}