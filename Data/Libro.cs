namespace BibliotecaBlazor.Data;

public class Libro
{
    public int Id { get; private set; }
        public string Titulo { get; private set; }

        public Libro(string titulo)
        {
            Titulo = titulo;
            Id = new Random().Next();
        }
}
