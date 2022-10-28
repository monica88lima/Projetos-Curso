// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercicio 03");

Console.WriteLine(" Digite sua Nota: ");
double Nota = double.Parse(Console.ReadLine());

if (Nota >= 6.0)
{
    Console.WriteLine(" Parabéns, você foi aprovado!! ");
}
else
{
    Console.WriteLine(" Que pena! Você foi Reprovado!! ");
}
