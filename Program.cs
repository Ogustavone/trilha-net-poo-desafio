using DesafioPOO.Models;

Smartphone nokia = new Nokia(numero: "12345", modelo: "Lumia 520", imei: "1234512345", memoria: 4);
Smartphone iphone = new Iphone(numero: "54321", modelo: "8 Plus", imei: "5432154321", memoria: 4);

// Teste Nokia
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.Write("\n");

// Teste Iphone
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

// Teste propriedades
Console.WriteLine("\nEspecificações Nokia");
Console.WriteLine($"- Número: {nokia.Numero}\n- Modelo: {nokia.Modelo}");
Console.WriteLine($"- Imei: {nokia.IMEI}\n- Memória: {nokia.Memoria}");

Console.WriteLine("\nEspecificações Iphone");
Console.WriteLine($"- Número: {iphone.Numero}\n- Modelo: {iphone.Modelo}");
Console.WriteLine($"- Imei: {iphone.IMEI}\n- Memória: {iphone.Memoria}");