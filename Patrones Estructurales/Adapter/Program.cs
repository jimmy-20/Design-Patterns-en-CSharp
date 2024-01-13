Console.WriteLine("Conversión de un cuadrado simulando un circulo");

//Queremos saber si el cuadrado encaja en el agujero
//Encaja si el radio del agujero es igual o mayor al ancho del cuadrado entre dos
//Si conocemos el ancho del cuadrado, podemos simular un circulo y verificar si los radios son iguales
AgujeroRedondo agujero = new AgujeroRedondo(5);
ClavijaCuadrada cuadrado = new ClavijaCuadrada(10);

ClavijaCuadradaAdaptador adaptador = new ClavijaCuadradaAdaptador(cuadrado);

if (agujero.EsIgual(adaptador)){
    Console.WriteLine("El cuadrado cabe perfecto en el agujero");
}else{
    Console.WriteLine("El cuadrado no cabe en el agujero");
}
