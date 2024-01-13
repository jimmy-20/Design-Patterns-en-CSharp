using System.Reflection;
using Builder;
using Builder.Models;
using Builder.Models.Concrete;
using static System.Console;

Director d = new Director(); //Instancia del director de constructores

//Instancias de objetos constructores
CarroBuilder cb = new();
ManualCarroBuilder m = new();


//Creando objetos con el director, este tiene configuraciones predeterminadas
Carro carro = d.CarroDeportivo(cb);
ManualCarro manual = d.ManualDeportivo(m);

WriteLine("El carro contiene:");
WriteLine("Marca: " + carro.Marca);
WriteLine("Modelo: " + carro.Modelo);
WriteLine("Motor: " + carro.Motor);
WriteLine("Gps: " + carro.Gps);

WriteLine("------------------------------------");

WriteLine("El manual dice:");
WriteLine("Marca: " + manual.Marca);
WriteLine("Modelo: " + manual.Modelo);
WriteLine("Asientos: " + manual.Asientos);
WriteLine("Gps: " + manual.Gps);