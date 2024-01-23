public class Bosque
{
    public List<Arbol> Arboles { get; set; } = new List<Arbol>();
    public void PlantarArbol(int x,int y,string textura, string nombre, string color){
        Arbol arbol = new Arbol(){
            X = x,
            Y = y,
            Textura = textura,
            Tipo = ArbolFabrica.ObtenerTipoArbol(nombre,color)
        };

        Arboles.Add(arbol);
    }
}