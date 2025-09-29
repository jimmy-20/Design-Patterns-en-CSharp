public class EstadoConcreto3 : IEstado
{
    public Context _context { get; private set; }
    public void Ejecutar()
    {
        Console.WriteLine("Se ejecutan acciones del Estado 3.");
        Console.WriteLine("Se regresa al Estado 1.\n");
        _context.TransitionTo(new EstadoConcreto1());
    }

    public void SetContext(Context context)
    {
        this._context = context;
    }
}