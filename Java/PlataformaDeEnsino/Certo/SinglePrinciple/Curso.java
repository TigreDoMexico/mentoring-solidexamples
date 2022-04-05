package PlataformaDeEnsino.Certo.SinglePrinciple;

import PlataformaDeEnsino.Certo.LiskovPrinciple.Professor;

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

    public String getErrors() {
        if (nome == null || nome.trim().isEmpty())
            return "O nome do curso não pode ser nulo";
        
        return null;
    }

    public Boolean isValido() {
        if (nome == null || nome.trim().isEmpty())
            return false;

        return true;
    }
}
