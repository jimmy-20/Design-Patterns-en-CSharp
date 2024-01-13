public interface IDispositivo
{
    bool EstaEncendido();
    void Encender();
    void Apagar();
    int ObtenerVolumen();
    void PonerVolumen(int volumen);
    int ObtenerCanal();
    void PonerCanal(int canal);
}