public class FileDataSourceDecorator : DataSource
{
    private DataSource wrappe;

    public FileDataSourceDecorator(DataSource w)
    {
        wrappe = w;
    }
    public virtual void EscribirDatos(string cad)
    {
        wrappe.EscribirDatos(cad);
    }

    public virtual string LeerDatos()
    {
        return wrappe.LeerDatos();
    }
}