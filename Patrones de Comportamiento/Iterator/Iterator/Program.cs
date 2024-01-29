var coleccion = new ColeccionPalabras();
coleccion.AgregarElemento("Primero");
coleccion.AgregarElemento("Segundo");
coleccion.AgregarElemento("Tercero");

foreach (var item in coleccion)
{
    Console.WriteLine(item);
}

coleccion.DireccionReversa();
Console.WriteLine("--- Ahora en Reversa ---");

foreach (var item in coleccion)
{
    Console.WriteLine(item);
}