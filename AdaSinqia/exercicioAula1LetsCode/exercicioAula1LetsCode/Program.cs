// See https://aka.ms/new-console-template for more information
using System;


//Título
//Subtitulo
//Autor
//Editora
//Número de páginas
//Data de publicação
//Idioma
//Após receber os dados, limpe o console e exiba os dados na tela.

Console.WriteLine("---- Cadastro Biblioteca ----");

Console.WriteLine("Digite o Título do Livro: ");
string tituloLivro = Console.ReadLine();  

Console.WriteLine("Digite o Subtitulo do Livro: ");
string subtituloLivro = Console.ReadLine();

Console.WriteLine("Digite o nome do autor: ");
string nomeAutor = Console.ReadLine();

Console.WriteLine("Digite o nome da Editora: ");
string nomeEditora = Console.ReadLine();

Console.WriteLine("Digite o número de páginas: ");
int numeroPaginas = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a data da publicação: dd/mm/aaaa:");
string dataPublicação = Console.ReadLine();


Console.WriteLine("Digite o idioma do livro:");
string idiomaLivro = Console.ReadLine();


Console.Clear();

Console.WriteLine("---- Livro Cadastrado----");

Console.WriteLine("Titulo: " + (tituloLivro.ToUpper()));
Console.WriteLine("Subtitulo: "+ subtituloLivro);
Console.WriteLine("Autor: " + nomeAutor);
Console.WriteLine("Editora: " + nomeEditora);
Console.WriteLine("Número de páginas: " + numeroPaginas + " páginas");
Console.WriteLine("Data da publicação: "+ dataPublicação);
Console.WriteLine("Idioma: "+ idiomaLivro);



