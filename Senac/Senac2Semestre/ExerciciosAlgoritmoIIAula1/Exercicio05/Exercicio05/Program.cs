// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercicio 5");
Console.WriteLine(" Digite a temperatura em Fahrenheit: ");
double temperatura = double.Parse(Console.ReadLine());

double celsius = (temperatura - 32) / 1.8;

Console.WriteLine(temperatura + "° em Fahrenheit equivale á " + celsius.ToString("F2") + "° Celsius" );

