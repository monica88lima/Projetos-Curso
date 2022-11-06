

Console.WriteLine("Exercicio 6");

Console.WriteLine("Digite um número: ");
//int numDigitado = int.Parse(Console.ReadLine());
bool validação = int.TryParse(Console.ReadLine(), out int numDigitado);

Console.WriteLine("Digite um número: ");
//int numDigitado = int.Parse(Console.ReadLine());
bool validação2 = int.TryParse(Console.ReadLine(), out int numDigitado2);

int resultado = Fatorial(numDigitado);
Console.WriteLine("Fatorial de " + numDigitado + " é " + resultado);

int resultado2 = Fatorial(numDigitado2);
Console.WriteLine("Fatorial de " + numDigitado2 + " é " + resultado2);

//var fatorial = 1;

//for(int i = 1; i <= numDigitado; i++)
//{
//    fatorial = i * fatorial;
//}
//    Console.WriteLine("Fatorial de " + numDigitado + " é "+ fatorial);
//    Console.WriteLine(validação);

static int Fatorial(int numero)
{
    var fatorial = 1;

    for (int i = 1; i <= numero; i++)
    {
        fatorial = i * fatorial;
    }
    return fatorial;
}