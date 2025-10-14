public class Invocador
{
    private IComando AlIniciar;
    private IComando AlFinalizar;

    public void ColocarInicio(IComando start)
    {
        AlIniciar = start;
    }

    public void ColocarFinal(IComando finish){
        AlFinalizar = finish;
    }

    public void HacerAlgoImportante(){
        if (AlIniciar is IComando){
            AlIniciar.Ejecutar();
        }

        if (AlFinalizar is IComando){
            AlFinalizar.Ejecutar();
        }


    }
}