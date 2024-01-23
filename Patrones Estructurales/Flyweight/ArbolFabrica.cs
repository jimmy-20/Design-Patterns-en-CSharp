public class ArbolFabrica
{
    private static List<TipoArbol> TiposArboles = new List<TipoArbol>();

    public static TipoArbol ObtenerTipoArbol(string nombre, string color){
        TipoArbol? tipo = TiposArboles.Find(x => x.Nombre == nombre && x.Color == color);

        if (tipo is null){
            tipo = new TipoArbol(nombre,color);
            TiposArboles.Add(tipo);
        }

        return tipo;
    }
}