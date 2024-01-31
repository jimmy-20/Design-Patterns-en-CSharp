public class ComponenteB : ComponenteBase
{
    public void HacerC(){
        Console.WriteLine("Componente B realiza tarea C");
        mediador.Notificar(this,"C");
    }

    public void HacerD(){
        Console.WriteLine("Componente B realiza tarea D");
        mediador.Notificar(this,"D");
    }
}