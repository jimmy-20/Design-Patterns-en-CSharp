using System.Collections;

public abstract class Iterador : IEnumerator
{
    object IEnumerator.Current => Current();

    //Llave del elemento
    public abstract int Llave();

    //Regresa el elemento actual
    public abstract object Current();

    //Avanzar al siguiente elemento
    public abstract bool MoveNext();

    //Regresa el Iterador al primer elemento
    public abstract void Reset();
}