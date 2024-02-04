Notificador notificador = new Notificador();

IObservador observador = new ObservadorConcreto();
IObservador observador2 = new ObservadorConcreto();
IObservador observador3 = new ObservadorConcreto();

notificador.AgregarObservador(observador);
notificador.AgregarObservador(observador2);
notificador.AgregarObservador(observador3);

Console.WriteLine();

notificador.LogicaNegocio();
notificador.LogicaNegocio();

Console.WriteLine();

notificador.EliminarObservador(observador2);

Console.WriteLine();

notificador.LogicaNegocio();
notificador.LogicaNegocio();