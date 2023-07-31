using Builder.Models;

namespace Builder
{
    public interface IBuilder<T>
    {
        void reset();
        void setAsientos(int numero);
        void setMotor(Motor m);
        void setComputadoraViaje();
        void setGPS();
        T Construir();
    }
}