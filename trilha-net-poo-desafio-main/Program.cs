using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia Android");
Nokia android = new Nokia(numero:"123123","A35","2232dsasd2342sda",512);
android.Ligar();
android.InstalarAplicativo("WeatherApp");

Console.WriteLine("Iphone X");
Iphone x = new Iphone(numero:"123123","X","2232dsasd2342sda",1024);
x.Ligar();
x.InstalarAplicativo("Icloud");