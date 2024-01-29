public class OrdenAlfabeticoIterador : Iterador
{
    private ColeccionPalabras Palabras;
    private bool Reversa = false;
    private int Posicion;

    public OrdenAlfabeticoIterador(ColeccionPalabras palabras, bool reversa)
    {
        Palabras = palabras;
        Reversa = reversa;

        //Operador ternario
        Posicion =  reversa is true ? Palabras.ObtenerColeccion().Count() : -1;
    }

    public override object Current() => Palabras.ObtenerColeccion()[Posicion];

    public override int Llave() => Posicion;

    public override bool MoveNext()
    {
        //Si Reversa es true, restar 1, si no, sumar 1
        int nuevaPosicion = Posicion + (Reversa ? -1 : 1);

        if (nuevaPosicion >= 0 && nuevaPosicion < Palabras.ObtenerColeccion().Count){
            Posicion = nuevaPosicion;
            return true;
        }else{
            return false;
        }
    }

    //Define la posición de donde empezará la coleccion
    public override void Reset()
    {
        Posicion = Reversa ? Palabras.ObtenerColeccion().Count - 1 : 0;
    }
}