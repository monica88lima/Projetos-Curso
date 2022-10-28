// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercicio 01");

    int contador = 0;
    int menor = 0, maior = 0, numDig;

    while (contador < 10)
    {
        Console.WriteLine("Digite um número:");
        numDig = int.Parse(Console.ReadLine());

        if (contador == 0)
        {
            maior = numDig;
            menor = numDig;
        }

        if (numDig > maior)
        {
            maior = numDig;
        }
        if (numDig < menor)
        {
            menor = numDig;
        }

        contador++;

    }
    Console.WriteLine($"O menor número digitado: " + menor);
    Console.WriteLine("O maior número digitado: " + maior);


