// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercicio 7 ");

Console.WriteLine("Digite o numero inicial: ");
int numInicial = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o numero final: ");
int numFinal = int.Parse(Console.ReadLine());
int soma = 0;
int contador = numInicial;





while(contador >= numInicial && contador <= numFinal)
{
    if(contador%2 == 0)
    {
        soma = contador + soma;
    }
  contador++;
}
{

    
    
}
Console.WriteLine(" A soma dos numeros pares entre " + numInicial + " e " + numFinal + " = " + soma);
