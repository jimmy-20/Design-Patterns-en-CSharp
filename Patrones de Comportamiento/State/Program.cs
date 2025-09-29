IEstado estadoInicial = new EstadoConcreto1();


Context context = new Context(estadoInicial);

for (int i = 0; i < 6; i++)
{
    context.Request();
}