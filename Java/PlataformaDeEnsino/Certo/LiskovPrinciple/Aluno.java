package PlataformaDeEnsino.Certo.LiskovPrinciple;

import java.util.List;
import PlataformaDeEnsino.Certo.SinglePrinciple.Curso;

public class Aluno extends Usuario {
    private List<Curso> cursos;

    public List<Curso> getCursos() {
        return cursos;
    }

    public void addCurso(Curso curso) {
        cursos.add(curso);
    }
}
