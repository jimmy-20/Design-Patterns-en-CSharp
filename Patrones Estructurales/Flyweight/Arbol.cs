public class Arbol
{
    public int X { get; set; }
    public int Y { get; set; }
    public string Textura { get; set; }
    public TipoArbol Tipo { get; set; }

    public void Dibujar(){
        Console.WriteLine("Árbol dibujado con:");
        Console.WriteLine("X: "+X);
        Console.WriteLine("Y: "+Y);
        Console.WriteLine("Nombre: "+Tipo.Nombre);
    }
}