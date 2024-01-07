using DesafioPOO.Models;



Console.WriteLine("\n\nSmartphone Nokia: \n");
Smartphone nokia = new  Nokia(numero: "123456789", modelo: "MotoG",imei: "987654321", 250 );
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");


Console.WriteLine("\n\nSmartphone Iphone: \n");
Smartphone iphone = new  Iphone(numero: "1212121212", modelo: "Iphone15",imei: "9999999999", 500 );
nokia.Ligar();
nokia.InstalarAplicativo("Instragram");