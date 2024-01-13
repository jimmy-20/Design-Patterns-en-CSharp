GraficoCompuesto compuesto = new GraficoCompuesto();
compuesto.Agregar(new Punto(2,3));
compuesto.Agregar(new Punto(5,6));
compuesto.Agregar(new Circulo(5,10,10));

GraficoCompuesto compuesto1 = new GraficoCompuesto();
compuesto1.Agregar(new Circulo(20,3,1));
compuesto1.Agregar(new Punto(30,30));

GraficoCompuesto compuesto2 = new GraficoCompuesto();
compuesto2.Agregar(new Circulo(50,12,5));
compuesto2.Agregar(new Punto(10,15));

GraficoCompuesto compuesto3 = new GraficoCompuesto();
compuesto3.Agregar(new Circulo(25,13,15));
compuesto3.Agregar(new Punto(125,55));

compuesto2.Agregar(compuesto3);
compuesto1.Agregar(compuesto2);
compuesto.Agregar(compuesto1);

compuesto.Dibujar();