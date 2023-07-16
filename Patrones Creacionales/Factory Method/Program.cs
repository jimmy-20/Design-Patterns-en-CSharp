using System;

Fabrica fabrica = new Fabrica();

var camion = fabrica.NuevoVehiculo(TipoVehiculo.Camion);
var barquito = fabrica.NuevoVehiculo(TipoVehiculo.Barco);

Console.WriteLine(camion.Transportar());
Console.WriteLine(barquito.Transportar());

Console.WriteLine($"El camión tiene un peso de :{camion.PesoTransporte()} Toneladas");
Console.WriteLine($"El barco tiene un peso de: {barquito.PesoTransporte()} Toneladas");