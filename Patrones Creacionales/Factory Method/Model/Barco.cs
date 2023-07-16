using Interfaces;

public class Barco : ITransporte
{
    public int Peso {get;set;} = 12;
    public int Turbinas {get;set;}

    public int PesoTransporte()
    {
        return Peso;
    }

    public string Transportar()
    {
        return "El transporte será vía marítima entonces";
    }
}