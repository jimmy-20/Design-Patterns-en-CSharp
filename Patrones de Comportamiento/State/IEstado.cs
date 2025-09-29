using System;

// Interfaz del estado
public interface IEstado
{
    void Ejecutar();
    void SetContext(Context context);
}
