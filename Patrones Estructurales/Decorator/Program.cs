Console.WriteLine("Iniciando programa...");

//Fichero 1
DataSource archivo = new FileDataSource("Mi Fichero");
archivo.EscribirDatos("Hola mundo sin formato"); //1. Solo escribe
Console.WriteLine(archivo.LeerDatos());

//Fichero 2
DataSource archivo2 = new FileDataSource("Mi Fichero 2");
DataSource archivo2Encriptado = new EncryptorDecorator(archivo2);
archivo2Encriptado.EscribirDatos("Hola mundo encriptado"); //1.Encripta y 2.Escribe
Console.WriteLine(archivo2Encriptado.LeerDatos());

//Fichero 3
DataSource archivo3 = new FileDataSource("Mi Fichero 3");
DataSource archivo3Encriptado = new EncryptorDecorator(archivo3);
DataSource archivo3Comprimido = new CompressionDecorator(archivo3Encriptado);
archivo3Comprimido.EscribirDatos("Hola mundo comprimido y encriptado"); //1.Comprime, 2.Encripta y 3.Escribe
Console.WriteLine(archivo3Comprimido.LeerDatos());