public class ComponenteBase
{
    protected IMediador mediador;

    public ComponenteBase(IMediador? m = null){
        this.mediador = m;
    }

    public void ColocarMediador(IMediador m){
        mediador = m;
    }
}