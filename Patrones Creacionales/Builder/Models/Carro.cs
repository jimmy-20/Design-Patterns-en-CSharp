namespace Builder.Models
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Asientos { get; set; }
        public Motor Motor { get; set; }
        public ComputadoraNav ComputadoraNav { get; set; }
        public Gps Gps { get; set; }
    }
}