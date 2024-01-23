Console.WriteLine("Creando bosque");
long memoriaAntes = GC.GetTotalMemory(true);

string[] Nombres = {"Madroño","Monje","Abedul"};
string[] Colores = {"Café","Negro","Blanco"};

string[] Texturas = {"Brote","Maduro","Caído","Seco"};

Bosque bosque = new Bosque();

for (int i =0; i<=10000000;i++)
{
    Random random = new Random();
    int tipoArbol = random.Next(0,3);

    bosque.PlantarArbol(
        i,
        i*2, 
        Texturas[random.Next(0,3)],
        Nombres.ElementAt(tipoArbol),
        Colores.ElementAt(tipoArbol)
        );
}

long memoriaDespues = GC.GetTotalMemory(true);
long memoriaUtilizada = memoriaDespues - memoriaAntes;
Console.WriteLine("Total de memoria utilizada: "+ Math.Round((double)memoriaUtilizada / (1024*1024),2) + "Mb");
