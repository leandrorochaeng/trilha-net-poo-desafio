using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111222333", memoria: 64);
nokia.Ligar();
//nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "789012", modelo: "Modelo 2", imei: "777888999", memoria: 256);
iphone.ReceberLigacao();
//iphone.Ligar();
iphone.InstalarAplicativo("Telegram");