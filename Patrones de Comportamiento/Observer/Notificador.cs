public class Notificador : INotificador
{
    public int Estado { get; private set; } = 0;
    private List<IObservador> Observadores { get; set; } = new();

    public void AgregarObservador(IObservador o)
    {
        Console.WriteLine("Notificador: Agrengando observador");
        Observadores.Add(o);
    }

    public void EliminarObservador(IObservador o)
    {
        Console.WriteLine("Notificador: Eliminando observador");
        Observadores.Remove(o);
    }

    public void Notificar()
    {
        Console.WriteLine("Notificador: !Se ha hecho un cambio!");
        Observadores.ForEach(o => o.Actualizar(this));
    }

    public void LogicaNegocio(){
        int numero = new Random().Next(0,10);
        Estado = numero;
        Notificar();
    }
}