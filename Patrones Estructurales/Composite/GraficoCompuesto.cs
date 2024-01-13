public class GraficoCompuesto : IGrafico
{
    private IGrafico[] Hijos;

    public void Agregar(IGrafico compuesto){
        if (Hijos is null){
            Hijos = new IGrafico[1];
            Hijos[0] = compuesto;
            return;
        }

        IGrafico[] temp = Hijos;
        int cantidadAnterior = temp.Length;

        Hijos = new IGrafico[cantidadAnterior+1];

        for (int i = 0; i < cantidadAnterior; i++)
        {
            Hijos[i] = temp[i];
        }

        Hijos[cantidadAnterior] = compuesto;
    }

    public void Remover(IGrafico compuesto){
    }


    public void Dibujar()
    {
        foreach (IGrafico hijo in Hijos){
            hijo.Dibujar();
        }
    }

    public void Mover(int x, int y)
    {
        foreach (IGrafico hijo in Hijos){
            hijo.Mover(x,y);
        }
    }
}