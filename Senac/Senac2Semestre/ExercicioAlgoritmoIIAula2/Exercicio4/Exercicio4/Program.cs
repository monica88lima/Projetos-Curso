// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercicio 4 !");

Console.WriteLine("Digite sua nota do Vestubular: ");
double nota = double.Parse(Console.ReadLine()); 
//nota de corte = 7.5
//nota MinimaAprovação = 8

if(nota >= 7.5 && nota <= 8)
{
    Console.WriteLine("Candidato entrou na lista de espera!");

}
else if(nota > 8)
{
    Console.WriteLine("Candidato Aprovado!");
}
else
{
    Console.WriteLine("Candidato Reprovado!");
}