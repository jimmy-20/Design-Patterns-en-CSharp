public class EstadoConcreto1 : IEstado{
    public Context _context { get; private set; }
    public void Ejecutar()
    {
        Console.WriteLine("Se ejecutan acciones del Estado 1.");
        _context.TransitionTo(new EstadoConcreto2());
    }

    public void SetContext(Context context)
    {
        this._context = context;
    }
}