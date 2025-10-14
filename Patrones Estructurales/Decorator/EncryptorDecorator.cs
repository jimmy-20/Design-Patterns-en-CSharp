public class EncryptorDecorator : FileDataSourceDecorator
{
    public EncryptorDecorator(DataSource w) : base(w){}

    public override void EscribirDatos(string cad)
    {
        Console.WriteLine("Encriptando datos");
        Console.WriteLine("Escribiendo datos encriptados");
        base.EscribirDatos(cad + ";Encriptados");
    }

    public override string LeerDatos()
    {
        Console.WriteLine("Leyendo datos");
        string contenido = base.LeerDatos();

        Console.WriteLine("Desencriptando datos");
        contenido = contenido.Replace(";Encriptados","");
        return contenido;
    }
}