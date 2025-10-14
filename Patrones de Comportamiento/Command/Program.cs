Invocador invocador = new ();

invocador.ColocarInicio(new ComandoSimple("Hola mundo"));

Receptor receptor = new();
invocador.ColocarFinal(new ComandoComplejo(receptor,"Enviar email","Ver reporte"));

invocador.HacerAlgoImportante();