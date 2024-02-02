//Es el encargado de llevar el seguimiento de cambios del origen
public class Cuidador
{
    public List<IMemento> mementos = new();
    public Origen origen = null;

    public Cuidador(Origen o)
    {
        origen = o;
    }

    public void Respaldar(){
        Console.WriteLine("Cuidador: Guardando el estado del Origen");
        mementos.Add(origen.Guardar());
    }

    public void Deshacer(){
        if (mementos.Count == 0){
            return;
        }

        var memento = mementos.Last();
        mementos.Remove(memento);

        Console.WriteLine("Restaurando el estado del memento "+memento.ObtenerEstado());
        
        try{
            origen.Restaurar(memento);
        }catch(Exception){
            Deshacer();
        }
    }

    public void VerHistorial(){
        Console.WriteLine("Cuidador: Aquí está su lista historial de cambios:");

        foreach (IMemento m in mementos)
        {
            Console.WriteLine(m.ObtenerNombre());
        }
    }
}