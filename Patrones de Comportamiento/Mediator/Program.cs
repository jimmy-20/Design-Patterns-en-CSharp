using static System.Console;
//Creando componentes
ComponenteA componenteA = new();
ComponenteB componenteB = new();

new MediadorConcreto(componenteA,componenteB);

WriteLine("Cliente dispara una operación A");
componenteA.HacerA();

WriteLine();

WriteLine("Cliente dispara una operación D");
componenteB.HacerD();