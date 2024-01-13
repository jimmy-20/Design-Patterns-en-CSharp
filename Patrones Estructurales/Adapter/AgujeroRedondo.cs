public class AgujeroRedondo
{
    public int Radio { get; set; }

    public AgujeroRedondo(int radio) => Radio=radio;

    public bool EsIgual(ClavijaRedonda cr){
        Console.WriteLine($"{Radio} >= {cr.ObtenerRadio()}?");
        if(Radio >= cr.ObtenerRadio()){
            return true;
        }

        return false;
    }
}