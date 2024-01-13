namespace Singleton
{
    public class SingletonTemplate
    {
        //Atributo en privado
        private static SingletonTemplate _singleton;

        //Constructor en privado
        private SingletonTemplate() => Console.WriteLine("Se creó una nueva instancia");

        //Método public estático
        public static SingletonTemplate GetInstance(){
            if (_singleton == null){
                _singleton = new();
            }

            Console.WriteLine("Se uso un Singleton");
            return _singleton;
        }
    }
}