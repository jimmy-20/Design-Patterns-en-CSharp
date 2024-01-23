public class Arbol
{
    public int X { get; set; }
    public int Y { get; set; }
    public string Nombre { get; set; }
    public string Color { get; set; }
    public string Textura { get; set; }

    public void Dibujar(){
        Console.WriteLine("Árbol dibujado con:");
        Console.WriteLine("X: "+X);
        Console.WriteLine("Y: "+Y);
        Console.WriteLine("Nombre: "+Nombre);
    }
}