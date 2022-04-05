package PlataformaDeEnsino.Certo.LiskovPrinciple;

import java.util.List;
import PlataformaDeEnsino.Certo.SinglePrinciple.Curso;

public class Professor extends Usuario {
    private List<Curso> aulas;

    public List<Curso> getAulas() {
        return aulas;
    }

    public void addAula(Curso curso) {
        aulas.add(curso);
    }
}
