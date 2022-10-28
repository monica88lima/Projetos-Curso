// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercicio 04");
Console.WriteLine("Digite o valor total: ");
double n = double.Parse(Console.ReadLine());

double resto;
var ret100 = (int)n / 100;
resto = n % 100;
var ret50 = (int)resto / 50;
resto = resto % 50;
var ret20 = (int)resto / 20;
resto = resto % 20;
var ret10 = (int)resto / 10;
resto = resto % 10;
var ret5 = (int)resto / 5;
resto = resto % 5;
var ret2 = (int)resto / 2;
resto = resto % 2;


var ret1Cent = resto / 1.00;
resto = resto % 1.00;
var ret050Cent = resto / 0.50;
resto = resto % 0.50;
var ret020Cent = resto / 0.25;
resto = resto % 0.25;
var ret010Cent = resto / 0.10;
resto = resto % 0.10;
var ret005Cent = resto / 0.05;
resto = resto % 0.05;
var ret001Cent = resto / 0.01;

Console.WriteLine("NOTAS: ");
Console.WriteLine($"{ret100} nota(s) de R$ 100.00");
Console.WriteLine($"{ret50} nota(s) de R$ 50.00");
Console.WriteLine($"{ret20} nota(s) de R$ 20.00");
Console.WriteLine($"{ret10} nota(s) de R$ 10.00");
Console.WriteLine($"{ret5} nota(s) de R$ 5.00");
Console.WriteLine($"{ret2} nota(s) de R$ 2.00");

Console.WriteLine("MOEDAS:");
Console.WriteLine($"{(int)ret1Cent} moeda(s) de R$ 1.00");
Console.WriteLine($"{(int)ret050Cent} moeda(s) de R$ 0.50");
Console.WriteLine($"{(int)ret020Cent} moeda(s) de R$ 0.25");
Console.WriteLine($"{(int)ret010Cent} moeda(s) de R$ 0.10");
Console.WriteLine($"{(int)ret005Cent} moeda(s) de R$ 0.05");
Console.WriteLine($"{(int)ret001Cent} moeda(s) de R$ 0.01");
