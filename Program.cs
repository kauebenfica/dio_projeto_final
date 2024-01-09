using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("(11) 991692205", "Tijolão", "00000000", 128);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");

Iphone iphone = new Iphone("(11) 991692205", "iPhone 15", "5555555", 64);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("facebook");