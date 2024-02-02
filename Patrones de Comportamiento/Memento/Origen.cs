public class Origen
{
    private string Estado;

    public Origen(string s)
    {
        Estado = s;
        Console.WriteLine("Origen: Mi estado inicial es: "+Estado);
    }

    public void HacerAlgo(){
        Console.WriteLine("Origen: Estoy haciendo algo");
        Thread.Sleep(2000);
        Estado = GenerateRandomString(30);
    }

    private string GenerateRandomString(int tamaño =10){
        string letras = "abcdefghijklmnñopqrstuvwxyz";
        string resultado = string.Empty;

        while (tamaño > 0){
            resultado += letras[new Random().Next(0,letras.Length)];
 
            Thread.Sleep(50);

            tamaño--;
        }

        return resultado;
    }

    public IMemento Guardar() => new MementoConcreto(Estado);

    public void Restaurar(IMemento memento){
        if ( !(memento is MementoConcreto)){
            throw new Exception("Clase Memento desconocida" + memento.ToString());
        }

        Estado = memento.ObtenerEstado();
        Console.WriteLine($"Origen: Mi estado ha cambiado a {Estado}");
    }
}