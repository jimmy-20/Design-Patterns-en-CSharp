using Builder.Models;

namespace Builder
{
    public class Director
    {
        public Carro CarroDeportivo(IBuilder<Carro> builder){
            builder.reset();
            builder.setAsientos(6);
            builder.setMotor(new Motor());

            return builder.Construir();
        }

        public ManualCarro ManualDeportivo(IBuilder<ManualCarro> builder){
            builder.reset();
            builder.setAsientos(6);
            builder.setGPS();
            return builder.Construir();
        }
    }
}