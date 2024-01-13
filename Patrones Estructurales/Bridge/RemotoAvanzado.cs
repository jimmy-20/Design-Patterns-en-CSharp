public class RemotoAvanzado : Remoto
{
    public RemotoAvanzado(IDispositivo d) : base(d)
    {
    }

    public void Mutear(){
        dispositivo.PonerVolumen(0);
    }
}