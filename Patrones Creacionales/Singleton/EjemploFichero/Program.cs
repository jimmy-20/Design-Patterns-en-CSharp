FileManager fm = FileManager.getInstanceFile("Archivo1");

fm.Write("1,Jose Perez," + DateTime.Now);
fm.Write("2,Maria Pereira," + DateTime.Now);
fm.Write("3,Jeison Reyes," + DateTime.Now);

Console.WriteLine(fm.Read());

fm.Update("2","2, Maria Perales," + DateTime.Now);

Console.WriteLine(fm.Read());

fm.Delete();