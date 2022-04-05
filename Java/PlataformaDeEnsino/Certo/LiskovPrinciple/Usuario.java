package PlataformaDeEnsino.Certo.LiskovPrinciple;

public abstract class Usuario {
    protected int id;
    protected String Nome;
    protected String Email;
    
    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getNome() {
        return Nome;
    }

    public void setNome(String nome) {
        Nome = nome;
    }

    public String getEmail() {
        return Email;
    }

    public void setEmail(String email) {
        Email = email;
    }
}
