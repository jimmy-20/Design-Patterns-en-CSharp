public class Context
{
    private IEstado _estado;

    public Context(IEstado estadoInicial)
    {
        TransitionTo(estadoInicial);
    }

    public void TransitionTo(IEstado estado)
    {
        Console.WriteLine($"Contexto: Transición a {estado.GetType().Name}.");
        _estado = estado;
        _estado.SetContext(this);
    }

    public void Request()
    {
        Thread.Sleep(1000);
        _estado.Ejecutar();
        Console.WriteLine("");
    }
}