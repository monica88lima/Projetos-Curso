// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercicio 6");

Console.WriteLine("Digite um número: ");
int numDigitado = int.Parse(Console.ReadLine());
var fatorial = 1;

for(int i = 1; i <= numDigitado; i++)
{
    fatorial = i * fatorial;
}
    Console.WriteLine("Fatorial de " + numDigitado + " é "+ fatorial);