namespace BibliotecaBlazor.Data;

public class Usuario : Persona
{
     private List<Libro> librosPrestados = new List<Libro>();
    public int Id { get; private set; }

    public Usuario(string nombre, string apellido) : base(nombre, apellido)
    {
        Id = new Random().Next();
    }

    public void PrestarLibro(Libro libro)
    {
        librosPrestados.Add(libro);
    }

    public void DevolverLibro(Libro libro)
    {
        librosPrestados.Remove(libro);
    }

    public List<Libro> ObtenerLibrosPrestados()
    {
        return librosPrestados;
    }

    public bool TieneLibroPrestado(Libro libro)
    {
        return librosPrestados.Contains(libro);
    }
}
