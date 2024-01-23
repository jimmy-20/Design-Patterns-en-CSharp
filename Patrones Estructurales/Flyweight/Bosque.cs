public class Bosque
{
    public List<Arbol> Arboles { get; set; } = new List<Arbol>();
    public void PlantarArbol(int x,int y, string nombre, string color, string textura){
        Arbol arbol = new Arbol(){
            X = x,
            Y = y,
            Nombre = nombre,
            Color = color,
            Textura = textura
        };

        Arboles.Add(arbol);
    }
}