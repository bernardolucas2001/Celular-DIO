using CelularDIO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "654321", modelo: "Modelo 1", imei: "1111111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "8000", modelo: "Modelo 2", imei: "2222222222", memoria: 256);
iphone.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");