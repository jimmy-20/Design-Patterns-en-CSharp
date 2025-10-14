public class Calculadora
{
    public IOperacion _operacion { private get; set; }

    public Calculadora()
    {
        _operacion = new Sumar();
    }
    public Calculadora(IOperacion operacion)
    {
        _operacion = operacion;
    }

    public double EjecutarOperacion(double a, double b)
    {
        return _operacion.Calcular(a, b);
    }
}