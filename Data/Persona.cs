namespace BibliotecaBlazor.Data;

public class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }

    public Persona(string nombre, string apellido)
    {
        Nombre = nombre;
        Apellido = apellido;
    }
}
