public class Television : Medio, IDispositivo
{
    //Los televisores puede contener pantalla de carga, y luego muestran imagen.
    public void Apagar()
    {
        Console.WriteLine("Apagando...");
        Thread.Sleep(3000);
        Estado = false;
    }

    public void Encender()
    {
        Estado = true;
        Console.WriteLine("Cargar pantalla de carga");
        Thread.Sleep(3000);
        Console.WriteLine("Cargar pantalla del canal");
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
        Console.WriteLine($"Canal: {Canal}");
        Canal = canal;
    }

    public void PonerVolumen(int volumen)
    {
        Console.WriteLine($"Volumen: {Volumen}");
        Volumen = volumen;
    }
}