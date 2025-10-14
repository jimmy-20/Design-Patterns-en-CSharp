public class ComandoComplejo : IComando
{
    private string a;
    private string b;
    private Receptor Receptor;

    public ComandoComplejo(Receptor r, string x,string y)
    {
        a = x;
        b = y;
        Receptor = r;
    }

    public void Ejecutar()
    {
        Console.WriteLine("Ejecutando comando complejo");
    }
}