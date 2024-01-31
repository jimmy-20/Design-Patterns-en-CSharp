public class MediadorConcreto : IMediador
{
    private ComponenteA componenteA;
    private ComponenteB componenteB;

    public MediadorConcreto(ComponenteA compA, ComponenteB compB)
    {
        componenteA = compA;
        componenteB = compB;

        componenteA.ColocarMediador(this);
        componenteB.ColocarMediador(this);
    }

    public void Notificar(object componente, string ev)
    {
        if (ev == "A"){
            Console.WriteLine("El mediador reacciona a 'A' y dispara la siguiente operación");
            componenteB.HacerC();
        }

        if (ev == "D"){
            Console.WriteLine("El mediador reacciona a 'D' y dispara la siguiente operación");
            componenteA.HacerB();
            componenteB.HacerC();
        }
    }
}