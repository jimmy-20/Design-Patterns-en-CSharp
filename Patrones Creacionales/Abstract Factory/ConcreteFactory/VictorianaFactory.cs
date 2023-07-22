using Abstract_Factory.Interfaces;
using Abstract_Factory.Models;

namespace Abstract_Factory.ConcreteFactory
{
    public class VictorianaFactory : AbstractFactory
    {
        public Mesa CrearMesa()
        {
            return new MesaVictoriana();
        }

        public Silla CrearSilla()
        {
            return new SillaVictoriana();
        }

        public Sofa CrearSofa()
        {
            return new SofaVictoriana();
        }
    }
}