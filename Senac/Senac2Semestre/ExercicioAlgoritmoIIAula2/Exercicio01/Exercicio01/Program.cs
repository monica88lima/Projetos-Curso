// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercicio 1 ");

Console.WriteLine("Informe o total ganhos deste mês: ");
double entrada = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o total gastos deste mês: ");
double saida = double.Parse(Console.ReadLine());

double res = entrada - saida;

if(entrada >= saida)
{
    Console.WriteLine("Você está dentro do orçamento! ");
}
else
{
    Console.WriteLine("Você está fora do orçamento! Não gaste mais! ");
}
