namespace Builder.Models.Concrete
{
    public class ManualCarroBuilder : IBuilder<ManualCarro>
    {
        private ManualCarro mCarro;

        public ManualCarro Construir()
        {
            return mCarro;
        }

        public void reset()
        {
            mCarro = new();
        }

        public void setAsientos(int numero)
        {
            mCarro.Asientos = numero;
        }

        public void setComputadoraViaje()
        {
            mCarro.ComputadoraNav = "La computadora de viaje contempla...";
        }

        public void setGPS()
        {
            mCarro.Gps = "El gps es del modelo X de la marca Z...";
        }

        public void setMotor(Motor m)
        {
            mCarro.Motor = "Motor de la marca Honda";
        }
    }
}