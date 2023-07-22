using Abstract_Factory.Models;

namespace Abstract_Factory.Interfaces
{
    public interface AbstractFactory
    {
        Silla CrearSilla();
        Mesa CrearMesa();
        Sofa CrearSofa();
    }
}