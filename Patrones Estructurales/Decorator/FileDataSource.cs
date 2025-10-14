public class FileDataSource : DataSource
{
    public string path;
    private StreamWriter? writer;
    private StreamReader? reader;

    public FileDataSource(string nombreFichero)
    {
        if (!File.Exists(nombreFichero)){
            using (File.Create(nombreFichero)){};
        }

        path = nombreFichero;
    }

    private StreamReader ObtenerLectura(){
        return (reader == null) ? new StreamReader(path) : reader;
    }

    private StreamWriter ObtenerEscritura(){
        return (writer == null) ? new StreamWriter(path) : writer;
    }

    private void CerrarFlujo(){
        if (writer != null){
            writer.Close();
            writer.Dispose();
            writer = null;
        }

        if (reader != null){
            reader.Close();
            reader.Dispose();
            reader = null;
        }
    }

    public void EscribirDatos(string cad)
    {
        writer = ObtenerEscritura();
        writer.WriteLine(cad);
        CerrarFlujo();
    }

    public string LeerDatos()
    {
        reader = ObtenerLectura();
        string contenido = reader.ReadToEnd();
        CerrarFlujo();
        return contenido;
    }
}