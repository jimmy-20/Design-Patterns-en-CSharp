using Abstract_Factory.Interfaces;
using Abstract_Factory.Models;

namespace Abstract_Factory.ConcreteFactory
{
    public class ModernaFactory : AbstractFactory
    {
        public Mesa CrearMesa()
        {
            return new MesaModerna();
        }

        public Silla CrearSilla()
        {
            return new SillaModerna();
        }

        public Sofa CrearSofa()
        {
            return new SofaModerna();
        }
    }
}