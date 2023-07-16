using Interfaces;

public class Fabrica
{
    public ITransporte? NuevoVehiculo(TipoVehiculo tipo){
        switch (tipo){
            case TipoVehiculo.Camion:
                return new Camion(){Peso=2};
            case TipoVehiculo.Barco:
                return new Barco();
            default:
                return null;
        }
    }
}