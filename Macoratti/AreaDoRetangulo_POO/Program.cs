
using AreaDoRetangulo_POO;

Area a1 = new Area();
Console.WriteLine("Resultado do cálculo da área");
Console.WriteLine("Informe valor da Base");
a1.altura= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe valor da altura");
a1.base_ = Convert.ToInt32(Console.ReadLine());

a1.Resultado_area();
