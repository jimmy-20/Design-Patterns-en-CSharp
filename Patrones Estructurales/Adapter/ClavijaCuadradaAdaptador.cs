public class ClavijaCuadradaAdaptador : ClavijaRedonda
{
    private ClavijaCuadrada _clavijaCuadrada;

    public ClavijaCuadradaAdaptador(ClavijaCuadrada cc){
        _clavijaCuadrada = cc;
    }

    public double ObtenerRadio()
    {
        return (_clavijaCuadrada.Ancho/2) * Math.Sqrt(2);
    }
}
