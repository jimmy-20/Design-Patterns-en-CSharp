public interface INotificador
{
    void AgregarObservador(IObservador o);
    void EliminarObservador(IObservador o);
    void Notificar();
}