public class Circulo : Punto
{
    private int Radio;
    public Circulo(int radio, int x, int y) : base(x, y)
    {
        Radio = radio;
    }

    public override void Dibujar(){
        Console.WriteLine("Se dibujo un círculo con radio "+ Radio+ $" en ({EjeX},{EjeY})");
    }

}