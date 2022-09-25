using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("519999999", "Modelo 1", "111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iPhone = new Iphone("001002022", "Modelo2", "2222222", 128);
iPhone.Ligar();
iPhone.InstalarAplicativo("Telegram");



