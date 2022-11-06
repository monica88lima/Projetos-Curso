// See https://aka.ms/new-console-template for more information
Console.WriteLine("Valores Inteiros!");
// /* */ comentarios
int valorInteiro = 10;

Console.WriteLine(valorInteiro);

valorInteiro = 20;
Console.WriteLine("Valor Alterado:");
Console.WriteLine(valorInteiro);

float valorFloat = 10.4f;
double valorDouble = 11.6;
double valorDouble2 = 11.6d;

decimal valorDecimal = 25.8m;

Console.WriteLine("-----------");
Console.WriteLine("Variaveis de Casas decimais");
Console.WriteLine(valorFloat);
Console.WriteLine(valorDouble);
Console.WriteLine(valorDecimal);

Console.WriteLine("--------------------");
Console.WriteLine("Variaveis escrita");
char valorChar = 'A';
string valorString = "Bem Vindos so coding Talk";

//valorTExto.Replace("a","outro")

Console.WriteLine(valorString);
Console.WriteLine(valorChar);

Console.WriteLine("--------------------------");
Console.WriteLine("Valores logicos");

bool valorBoolean = true;
Console.WriteLine(valorBoolean);


bool valorBoolean2 = false;
Console.WriteLine("Valor logico alterado");
Console.WriteLine(valorBoolean2);


Console.WriteLine("---------------------------");

Console.WriteLine("Digite seu nome:");
string nomeDigitado = Console.ReadLine();
Console.WriteLine(nomeDigitado);


//https://chat.whatsapp.com/C7sf1lCtY0ULPMIhI9UW6U

////Exercicio: Crie um cadastro de uma biblioteca.
//Leia os seguintes dados:
//Título
//Subtitulo
//Autor
//Editora
//Número de páginas
//Data de publicação
//Idioma
//Após receber os dados, limpe o console e exiba os dados na tela.