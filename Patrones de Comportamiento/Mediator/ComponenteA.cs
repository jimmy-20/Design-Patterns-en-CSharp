public class ComponenteA : ComponenteBase
{
    public void HacerA(){
        Console.WriteLine("Componente A realiza tarea A");
        mediador.Notificar(this,"A");
    }

    public void HacerB(){
        Console.WriteLine("Componente A realiza tarea B");
        mediador.Notificar(this,"B");
    }
}