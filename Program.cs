using DesafioPOO.Models;

Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.InstalarAplicativo("Whatsapp");

Smartphone iPhone = new Iphone(numero: "513542", modelo: "Modelo 1", imei: "111111111", memoria: 64);
iPhone.InstalarAplicativo("Tinder");

nokia.Ligar(iPhone);