
using DesafioPOO.Models;

Console.ForegroundColor = ConsoleColor.DarkBlue;
System.Console.WriteLine("Smartphone Iphone");

Smartphone iphone = new Iphone("347", "15", "5555", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");

Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkGreen;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("989", "13", "9999", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");
Console.ResetColor();
