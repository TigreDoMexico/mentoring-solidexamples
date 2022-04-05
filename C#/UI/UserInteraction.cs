namespace PlataformaDeEnsino.UI;

public class UserInteraction {
    public void MostrarBoasVindas() {
        Console.Clear();
        Console.WriteLine("==== BEM-VINDOS A PLATAFORMA DE ENSINO ====");
        Console.WriteLine("      [PRESSIONE ENTER PARA CONTINUAR]     ");
        Console.ReadLine();
    }

    public void MostrarOpcoes()
    {
        int opcao = -1;
        bool programaExecutando = true;

        while(programaExecutando) {
            Console.Clear();
            Console.WriteLine("==== SELECIONE UMA OPÇÃO DESEJADA ====");
            Console.WriteLine("1 - CURSOS");
            Console.WriteLine("2 - PROFESSORES");
            Console.WriteLine("3 - ALUNOS");
            Console.WriteLine("0 - SAIR");
            Console.ReadLine();

            opcao = ObterEntradaUsuario();

            switch(opcao) {
                case 1:
                    // Faz acesso ao curso
                    break;
                case 2:
                    // Faz acesso ao professor
                    break;
                case 3:
                    // Faz acesso ao aluno
                    break;
                case 0:
                    programaExecutando = false;
                    break;
                default:
                    Console.WriteLine("==== SELECIONE UMA OPÇÃO DESEJADA ====");
                    break;
            }
        }
    }

    public int ObterEntradaUsuario()
    {
        int entradaValida = 0;
        while(entradaValida == 0)
        {
            int.TryParse(Console.ReadLine(), out entradaValida);
            if(entradaValida == 0)
                Console.WriteLine("Entrada Inválida");
        }

        return entradaValida;
    }
}
