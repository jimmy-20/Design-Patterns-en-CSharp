
public class MementoConcreto : IMemento
{
    private string Estado;
    private DateTime Fecha;

    public MementoConcreto(string e)
    {
        Estado = e;
        Fecha = DateTime.Now;
    }

    public string ObtenerEstado() => Estado;

    public DateTime ObtenerFecha() => Fecha;

    public string ObtenerNombre() => $"{Fecha} / {Estado.Substring(0,9)}...";
}