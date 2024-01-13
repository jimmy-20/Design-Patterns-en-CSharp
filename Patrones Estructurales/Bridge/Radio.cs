public class Radio : Medio,IDispositivo
{
    //Los radios no hay algo que te informe que está encendido, hasta que lo oyes funcionar.
    public void Apagar()
    {
        Estado = false;
    }

    public void Encender()
    {
        Estado = true;
    }

    public bool EstaEncendido()
    {
        return Estado;
    }

    public int ObtenerCanal()
    {
        return Canal;
    }

    public int ObtenerVolumen()
    {
        return Volumen;
    }

    public void PonerCanal(int canal)
    {
        Console.WriteLine($"Interferencia...");
        Canal = canal;
    }

    public void PonerVolumen(int volumen)
    {
        Console.WriteLine("Bajando o subiendo volumen");
        Volumen = volumen + 10;
    }
}