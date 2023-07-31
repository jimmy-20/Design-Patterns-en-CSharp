namespace Builder.Models
{
    [Serializable]
    public class ManualCarro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Asientos { get; set; }
        public string Motor { get; set; }
        public string ComputadoraNav { get; set; }
        public string Gps { get; set; }
    }
}