// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercicio 8");

Console.WriteLine("Digite uma frase: ");
string frase = Console.ReadLine();

int tamanho = frase.Length;
char[] caracteres = frase.ToCharArray();

foreach(char value in caracteres)
{
    Console.Write(value + "-");
}
