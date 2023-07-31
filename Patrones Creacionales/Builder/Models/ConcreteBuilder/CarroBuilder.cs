namespace Builder.Models.Concrete
{
    public class CarroBuilder : IBuilder<Carro>
    {
        private Carro carro;

        public CarroBuilder()
        {
            carro = new();
        }

        public Carro Construir()
        {
            return carro;
        }

        public void reset()
        {
            carro = new();
        }

        public void setAsientos(int numero)
        {
            carro.Asientos = numero;
        }

        public void setComputadoraViaje()
        {
            carro.ComputadoraNav = new();
        }

        public void setGPS()
        {
            carro.Gps = new();
        }

        public void setMotor(Motor m)
        {
            carro.Motor = m;
        }

    }
}