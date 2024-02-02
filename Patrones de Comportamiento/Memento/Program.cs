Origen origen = new Origen("Super-Duper");
Cuidador cuidador = new Cuidador(origen);

cuidador.Respaldar();

origen.HacerAlgo();
cuidador.Respaldar();

origen.HacerAlgo();
cuidador.Respaldar();

origen.HacerAlgo();
cuidador.Respaldar();

Console.WriteLine();

cuidador.VerHistorial();

Console.WriteLine();

Console.WriteLine("Deshaciendo cambios");
cuidador.Deshacer();
cuidador.Deshacer();

cuidador.VerHistorial();
