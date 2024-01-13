public class Punto: IGrafico
{
    protected int EjeX;
    protected int EjeY;

    public Punto(int x, int y)
    {
        EjeX = x;
        EjeY = y;
    }

    public virtual void Dibujar()
    {
        Console.WriteLine($"Se dibujo un punto en la coordenada ({EjeX},{EjeY})");
    }

    public void Mover(int x, int y)
    {
        EjeX += x;
        EjeY += y;
    }
}