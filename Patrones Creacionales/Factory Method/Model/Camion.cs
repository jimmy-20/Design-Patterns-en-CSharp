
using Interfaces;

public class Camion : ITransporte
{
    public int Peso { get; set; }
    public int Llantas { get; set; }
    public string Marca { get; set; }

    public int PesoTransporte()
    {
        return Peso;
    }

    public string Transportar()
    {
        return "El transporte será vía terrestre entonces";
    }
}