// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercicio 1061 - Curso udemy");


Console.WriteLine("Digite o dia ");
string [] dia = Console.ReadLine().Split(' ');

string txt = dia[0];


int diaInicio = int.Parse(dia[1]);



Console.WriteLine("dia a hora inicial: ");
string[] hora = Console.ReadLine().Split(':');


int horaInicio = int.Parse(hora[0]);
int minutosInicio = int.Parse(hora[1]);
int segundosInicio = int.Parse(hora[2]);

Console.WriteLine("Digite o dia do fim ");
string[] diaFim = Console.ReadLine().Split(' ');

string txt2 = diaFim[0];
int diaFinal = int.Parse(diaFim[1]);



Console.WriteLine("dia a hora final: ");
string[] horaFim = Console.ReadLine().Split(':');



int horaFinal = int.Parse(horaFim[0]);
int minutosFinal = int.Parse(horaFim[1]);
int segundosFinal = int.Parse(horaFim[2]);
int w = diaFinal - diaInicio;


if (horaInicio > horaFinal)
{
    w = w - 1;
}
else
{
    w = w;
}
double x = Math.Round(w * 7.33);


int y = minutosFinal - minutosInicio;
int z = segundosFinal - segundosInicio;


Console .WriteLine(w + " dia (s)");
Console.WriteLine(x + " hora (s)");
Console.WriteLine(y+ " minutos (s)");
Console.WriteLine(z + " segundos (s)");
