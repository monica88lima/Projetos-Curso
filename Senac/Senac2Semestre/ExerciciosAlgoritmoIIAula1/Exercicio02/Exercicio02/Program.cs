// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercicio 02");

Console.WriteLine(" Quantidade de votos do Candidato A: ");
int candidatoA = int.Parse(Console.ReadLine());
Console.WriteLine(" Quantidade de votos do Candidato B: ");
int candidatoB = int.Parse(Console.ReadLine());
Console.WriteLine(" Quantidade de votos do Candidato C: ");
int candidatoC = int.Parse(Console.ReadLine());
Console.WriteLine(" Quantidade de votos Nulos: ");
int nulos = int.Parse(Console.ReadLine());
Console.WriteLine(" Quantidade de votos do em Branco: ");
int branco = int.Parse(Console.ReadLine());

int total = candidatoA + candidatoB + candidatoC + nulos + branco;

double A = (100.00 * candidatoA) / total;
double B = (100.00 * candidatoB) / total;
double C = (100.00 * candidatoC) / total;
double Nu = (100.00 * nulos) / total;
double Bra = (100.00 * branco) / total;

Console.WriteLine(" Total de Votos:  " + total);

Console.WriteLine(" A porcentagem do Candidato A foi: " + A.ToString("F3") + "%");
Console.WriteLine(" A porcentagem do Candidato B foi: " + B.ToString("F3") + "%");
Console.WriteLine(" A porcentagem do Candidato C foi: " + C.ToString("F3") + "%");
Console.WriteLine(" A porcentagem de votos Nulos foi: " + Nu.ToString("F3") + "%");
Console.WriteLine(" A porcentagem de votos em Branco foi: " + Bra.ToString("F3") + "%");
