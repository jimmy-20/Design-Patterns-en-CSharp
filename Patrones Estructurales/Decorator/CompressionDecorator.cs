public class CompressionDecorator : FileDataSourceDecorator
{
    public CompressionDecorator(DataSource w) : base(w){}

    public override void EscribirDatos(string cad)
    {
        Console.WriteLine("Comprimiendo datos");
        Console.WriteLine("Escribiendo datos comprimidos");
        base.EscribirDatos(cad +";Comprimidos");
    }

    public override string LeerDatos()
    {
        Console.WriteLine("Leyendo datos");
        string contenido = base.LeerDatos();

        Console.WriteLine("Descomprimiendo datos");
        contenido = contenido.Replace(";Comprimidos","");

        return contenido;
    }
}