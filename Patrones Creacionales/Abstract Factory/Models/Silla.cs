namespace Abstract_Factory.Models
{
    public abstract class Silla
    {
        public int Patas { get; set; }
        public string Marca { get; set; }
        public double Peso { get; set; }
        public string Color { get; set; }
        public double Precio { get; set; }
        public bool EsInclinable { get; set; }
    }
}