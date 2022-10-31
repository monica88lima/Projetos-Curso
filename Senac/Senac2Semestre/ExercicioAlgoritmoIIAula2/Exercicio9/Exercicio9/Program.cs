// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercicio 9");

Console.WriteLine("Digite uma PALAVRA ou FRASE: ");
string palavra = Console.ReadLine();


char[] caracteres = palavra.ToCharArray();
Array.Reverse(caracteres);

Console.WriteLine(caracteres);



