using DesafioPOO.Models;
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia (numero: "48999999999", modelo: "Model 1", imei: "1111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone (numero: "48988888888", modelo: "Model 2", imei: "1111112", memoria: 128);
Console.WriteLine(iphone.Numero);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
iphone.Numero = "abc";
Console.WriteLine(iphone.Numero);