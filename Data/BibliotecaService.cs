namespace BibliotecaBlazor.Data;

public class BibliotecaService
{
    public List<Bibliotecario> Bibliotecarios { get; private set; }
    public List<Usuario> Usuarios { get; private set; }

    public BibliotecaService()
    {
        Bibliotecarios = new List<Bibliotecario>();
        Usuarios = new List<Usuario>();
    }
}
