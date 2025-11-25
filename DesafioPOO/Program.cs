using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);

nokia.Numero = "987654";
Console.WriteLine($"{nokia.Numero} {nokia.Modelo} {nokia.Memoria}");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Console.WriteLine("Smartphone Nokia:");
Smartphone iphone = new Iphone(numero: "555333", modelo: "Modelo 2", imei: "222222222", memoria: 128);
Console.WriteLine($"{iphone.Numero} {iphone.Modelo} {iphone.Memoria}");
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
