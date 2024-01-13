Console.WriteLine("Iniciando Programa");

Television tv = new Television();
Remoto control = new Remoto(tv);
Console.WriteLine("Encendiendo televisión");
control.AlternarEncendido();
control.SubirVolumen();
control.SubirVolumen();
control.SubirVolumen();
control.SubirVolumen();
control.SubirVolumen();
Console.WriteLine("Apagando televisión");
control.AlternarEncendido();

Console.WriteLine();

Radio radio = new Radio();
control = new Remoto(radio);
Console.WriteLine("Encendiendo Radio");
control.AlternarEncendido();
control.PonerCanal(1,5);
control.PonerCanal(5,9);
control.SubirVolumen();
Console.WriteLine("Apagando Radio");
control.AlternarEncendido();

Console.WriteLine();

Television tv2 = new Television();
RemotoAvanzado remotoAvanzado = new RemotoAvanzado(tv2);
Console.WriteLine("Encendiendo televisión inteligente");
remotoAvanzado.AlternarEncendido();
remotoAvanzado.SubirVolumen();
remotoAvanzado.SubirVolumen();
remotoAvanzado.SubirVolumen();
remotoAvanzado.SubirVolumen();
remotoAvanzado.SubirVolumen();
remotoAvanzado.SubirVolumen();
remotoAvanzado.SubirVolumen();
remotoAvanzado.SubirVolumen();
remotoAvanzado.SubirVolumen();
remotoAvanzado.Mutear();
remotoAvanzado.SubirVolumen();
Console.WriteLine("Apagando televisión inteligente");
remotoAvanzado.AlternarEncendido();