public class TipoArbol
{
    public string Nombre { get; private set; }
    public string Color { get; private set; }

    public TipoArbol(string nombre, string color)
    {
        Nombre = nombre;
        Color = color;
    }
}