using Abstract_Factory.Interfaces;
using Abstract_Factory.Models;

namespace Abstract_Factory.ConcreteFactory
{
    public class ArtFactory : AbstractFactory
    {
        public Mesa CrearMesa()
        {
            MesaArt m = new MesaArt(){
                Marca = "Mesa Artistica S.A",
            };
            
            return m;
        }

        public Silla CrearSilla()
        {
            SillaArt s = new SillaArt(){
                Marca = "Silla Artistica S.A"
            };

            return s;
        }
        public Sofa CrearSofa()
        {
            SofaArt sof = new SofaArt(){
                Marca = "Sofa Artistico"
            };

            return sof;
        }
    }
}