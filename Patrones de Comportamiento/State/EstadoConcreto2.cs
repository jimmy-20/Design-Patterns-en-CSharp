public class EstadoConcreto2 : IEstado
{
    public Context _context { get; private set; }
    public void Ejecutar()
    {
        Console.WriteLine("Se ejecutan acciones del Estado 2.");
        _context.TransitionTo(new EstadoConcreto3());

    }

    public void SetContext(Context context)
    {
        this._context = context;
    }
}