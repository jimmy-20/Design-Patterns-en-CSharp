namespace Abstract_Factory.Models
{
    public abstract class Mesa
    {
        public int Patas { get; set; }
        public string Marca { get; set; }
        public double Peso { get; set; }
        public string Color { get; set; }
        public float Altura { get; set; }
        public double Precio { get; set; }
    }

    public class Persona{
        public string Nombre{get;private set;}

        public int edad;

    }
}