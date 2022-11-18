using Exercicio_POO.Model;

Pessoa p1;
Pessoa p2;
Pessoa p3;

p1 = new Pessoa();
Console.WriteLine("Nome da 1a pessoa");
p1.Nome = Console.ReadLine();

Console.WriteLine("Idade da 1a pessoa");
p1.Idade = Convert.ToInt32(Console.ReadLine());

p2 = new Pessoa();
Console.WriteLine("Nome da 2a pessoa");
p2.Nome = Console.ReadLine();

Console.WriteLine("Idade da 2a pessoa");
p2.Idade = Convert.ToInt32(Console.ReadLine());

p3 = new Pessoa();
Console.WriteLine("Nome da 3a pessoa");
p3.Nome = Console.ReadLine();

Console.WriteLine("Idade da 3a pessoa");
p3.Idade = Convert.ToInt32(Console.ReadLine());


if (p1.Idade > p2.Idade && p1.Idade > p3.Idade)
{
    Console.WriteLine("A pessoa que tem...");
    p1.ExibirDados();
}
else if (p2.Idade > p1.Idade && p2.Idade > p3.Idade)
{
     Console.WriteLine("A pessoa que tem...");
    p2.ExibirDados();
}else{

     Console.WriteLine("A pessoa que tem...");
    p3.ExibirDados();
}