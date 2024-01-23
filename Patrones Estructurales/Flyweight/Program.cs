Console.WriteLine("Creando bosque");
long memoriaAntes = GC.GetTotalMemory(true);

string[] Nombres = {"Madroño","Monje","Abedul"};
string[] Colores = {"Café","Negro","Blanco"};
string[] Texturas = {"Brote","Maduro","Caído","Seco"};

Bosque bosque = new Bosque();

for (int i =0; i<=10000000;i++){
    Random random = new Random();
    int tipoArbol = random.Next(0,2);

    bosque.PlantarArbol(
        i,
        i*2,
        Nombres[tipoArbol],
        Colores[tipoArbol], 
        Texturas[random.Next(0,3)]);
}

long memoriaDespues = GC.GetTotalMemory(true);
long memoriaUtilizada = memoriaDespues - memoriaAntes;
Console.WriteLine("Total de memoria utilizada: "+ Math.Round((double)memoriaUtilizada / (1024*1024),2) + "Mb");
