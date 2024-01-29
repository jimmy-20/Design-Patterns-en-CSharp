using System.Collections;

public class ColeccionPalabras : IteradorAgregado
{
    private List<string> coleccion = new();
    public bool direccion = false;

    public void DireccionReversa() => direccion = !direccion;
    public List<string> ObtenerColeccion() => coleccion;
    public void AgregarElemento(string item) => coleccion.Add(item);

    public override IEnumerator GetEnumerator() => new OrdenAlfabeticoIterador(this, direccion);
}