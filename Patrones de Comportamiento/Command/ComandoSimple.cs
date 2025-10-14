public class ComandoSimple : IComando
{
    private string Pago;

    public ComandoSimple(string pago)
    {
        Pago = pago;
    }

    public void Ejecutar()
    {
        Console.WriteLine("Ejecutando comando simple: "+Pago);
    }
}