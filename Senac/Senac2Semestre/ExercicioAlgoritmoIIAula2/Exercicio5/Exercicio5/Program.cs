// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Exercicio 5!");

Console.WriteLine("Informe o total de Ganhos: ");
double ganhos = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o total de Gastos: ");
double gastos = double.Parse(Console.ReadLine());

double total = ganhos - gastos;
double resultadoPercentual = (gastos * 100) / ganhos;
Math.Round(resultadoPercentual,2);

if(resultadoPercentual > 100)
{
    Console.WriteLine("Orçamento comprometido! Hora de rever seus gastos!");
}
else if(resultadoPercentual >= 81 && resultadoPercentual <= 100)
{
    Console.WriteLine("Cuidado, seu orçamento pode ficar comprometido");
}
else if (resultadoPercentual >= 51 && resultadoPercentual <= 80)
{
    Console.WriteLine("Atenção, melhor conter os gastos!");
}
else if (resultadoPercentual >= 21 && resultadoPercentual <= 50)
{
    Console.WriteLine("Muito bem, seus gastos não ultrapassam metade dos ganhos!");
}
else
{
    Console.WriteLine("Parabéns, está gerenciando bem seu orçamento!");
}

Console.WriteLine("Seus gastos representam " + resultadoPercentual.ToString("F2") + "% de seus ganhos!");



