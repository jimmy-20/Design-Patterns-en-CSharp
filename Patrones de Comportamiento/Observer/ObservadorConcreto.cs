public class ObservadorConcreto : IObservador
{
    public int Estado { get; set; } = 0;
    public void Actualizar(INotificador notificador)
    {
        int estado = ((Notificador)notificador).Estado;

        if (estado > 3){
            Estado = estado;
            Console.WriteLine("Observadores: He cambiado mi estado a " + Estado);
            Thread.Sleep(1000);
        }

    }
}