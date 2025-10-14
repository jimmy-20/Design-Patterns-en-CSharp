public class Dividir : IOperacion
{
    public double Calcular(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("No se puede dividir por cero.");
        }
        return a / b;
    }
}