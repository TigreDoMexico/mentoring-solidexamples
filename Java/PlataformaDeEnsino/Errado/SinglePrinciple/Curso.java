package PlataformaDeEnsino.Errado.SinglePrinciple;

public class Curso {
    private int id;
    private String nome;
    private Professor professor;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public Professor getProfessor() {
        return professor;
    }

    public void setProfessor(Professor professor) {
        this.professor = professor;
    }

    public String CriarNovoCurso() {
        if(nome == null || nome.trim().isEmpty())
            return "O curso precisa de um nome";

        // Conexão com o Banco

        // Envio de Email

        return "Curso cadastrado com sucesso";
    }

    
}
