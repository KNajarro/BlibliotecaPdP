using BibliotecaBlazor.Data;

namespace BibliotecaBlazor;

public class Bibliotecario : Persona
{ 
    private List<Libro> librosAsignados = new List<Libro>();
        public int Id { get; private set; }

        public Bibliotecario(string nombre, string apellido) : base(nombre, apellido)
        {
            Id = new Random().Next();
        }

        public void AsignarLibro(Libro libro)
        {
            librosAsignados.Add(libro);
        }

        public List<Libro> ObtenerLibros()
        {
            return librosAsignados;
        }
}
