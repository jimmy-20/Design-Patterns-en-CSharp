public class Remoto
{
    protected IDispositivo dispositivo;

    public Remoto(IDispositivo d)
    {
        dispositivo=d;
    }
    public void AlternarEncendido(){
        bool estado = dispositivo.EstaEncendido();

        if (estado){
            dispositivo.Apagar();
        }else{
            dispositivo.Encender();
        }
    }

    public void SubirVolumen(){
        int volumenActual = dispositivo.ObtenerVolumen();

        if (volumenActual == 100){
            Console.WriteLine("Volumen Máximo!");
            return;
        }

        dispositivo.PonerVolumen(++volumenActual);
    }

    public void BajarVolumen(){
        int volumenActual = dispositivo.ObtenerVolumen();

        if(volumenActual==0){
            Console.WriteLine("Volumen Mínimo");
        }

        dispositivo.PonerVolumen(--volumenActual);
    }

    public void SiguienteCanal(){
        int canalActual = dispositivo.ObtenerCanal();

        dispositivo.PonerCanal(++canalActual);
    }

    public void AnteriorCanal(){
        int canalActual = dispositivo.ObtenerCanal();

        dispositivo.PonerCanal(--canalActual);
    }

    public void PonerCanal(int num1, int num2){
        int nuevoCanal = int.Parse(string.Concat(num1,num2));

        dispositivo.PonerCanal(nuevoCanal);
    }
}