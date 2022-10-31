//See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercicio 10");

Console.WriteLine("Digite uma PALAVRA ou FRASE: ");
string palavra = Console.ReadLine();


char[] caracteres = palavra.ToCharArray();
Array.Reverse(caracteres);

string textoInvertido = string.Join("", caracteres);

if (palavra == textoInvertido)
{
    Console.WriteLine(" É um palíndromo");
}
else
{
    Console.WriteLine(" Não é um palíndromo.");
}




