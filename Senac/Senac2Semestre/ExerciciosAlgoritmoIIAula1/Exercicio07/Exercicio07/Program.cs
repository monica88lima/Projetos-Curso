// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercicio 07");

Console.WriteLine(" Digite o ano: ");
int ano = int.Parse(Console.ReadLine());



if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
{
    Console.WriteLine("Bissexto");
}
else
{
    Console.WriteLine("Não é Ano Bissexto");
}
