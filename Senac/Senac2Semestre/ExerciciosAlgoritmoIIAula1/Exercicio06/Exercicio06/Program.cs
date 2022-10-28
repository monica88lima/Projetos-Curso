// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercicio 06");

Console.WriteLine(" Digite o ano do seu nascimento: ");
int anoNasc = int.Parse(Console.ReadLine());

var dataAtual = new DateTime();
dataAtual = DateTime.Now;
int idade = (dataAtual.Year) - anoNasc;

if (idade >= 16 && idade < 18 || idade >= 66)
{
    Console.WriteLine("Você tem: " + idade + " anos");
    Console.WriteLine("Voto Opcional");
}
else if (idade >= 18)
{
    Console.WriteLine("Você tem: " + idade + " anos");
    Console.WriteLine("Voto Obrigatório");
}
else
{
    Console.WriteLine("Você tem: " + idade + " anos");
    Console.WriteLine("Você não tem idade para votar.");
}
