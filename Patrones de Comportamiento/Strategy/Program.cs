Console.WriteLine("Patrón Strategy");
Calculadora calc = new Calculadora();
int opcion;

do
{
    //Selección de la operación
    Console.WriteLine("Seleccione una operación:");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Salir");
    opcion = int.Parse(Console.ReadLine());

    if (opcion < 1 || opcion > 5)
    {
        Console.WriteLine("Opción no válida, intente de nuevo.");
        continue;
    }
    //Lectura de los números
    Console.WriteLine("Ingrese el primer número:");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo número:");
    double b = double.Parse(Console.ReadLine());

    //Presentar resultado
    double resultado = ResultadoOperacion((Opcion)(opcion - 1), a, b, calc);
    Console.WriteLine($"El resultado es: {resultado}");
} while (opcion != 5);


double ResultadoOperacion(Opcion o, double a, double b, Calculadora calc)
{
    switch (o)
    {
        case Opcion.Sumar:
            calc._operacion = new Sumar();
            break;
        case Opcion.Restar:
            calc._operacion = new Restar();
            break;
        case Opcion.Multiplicar:
            calc._operacion = new Multiplicar();
            break;
        case Opcion.Dividir:
            calc._operacion = new Dividir();
            break;
        default:
            Console.WriteLine("Opción no válida");
            break;
    }

    return calc.EjecutarOperacion(a, b);
}

public enum Opcion
{
    Sumar,
    Restar,
    Multiplicar,
    Dividir
}