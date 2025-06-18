using DesafioPOO.Models;

Console.WriteLine("Testando iPhone:");
Smartphone iphone = new Iphone(numero: "99999", modelo: "iPhone 14", imei: "111111111", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\nTestando Nokia:");
Smartphone nokia = new Nokia(numero: "88888", modelo: "Nokia Tijolão", imei: "222222222", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake Game");
