// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//DateTime dataHoje = new DateTime(22, 11, 03);

//Console.WriteLine(dataHoje);

//DateTime dataHojeHora = new DateTime(22, 11, 03, 19, 25, 30);
//Console.WriteLine(dataHojeHora);

//DateTime dataHoraSistema = DateTime.Now;
//Console.WriteLine(dataHoraSistema);

//Console.WriteLine(dataHoraSistema.Year);
//Console.WriteLine(dataHoraSistema.ToShortDateString());
//Console.WriteLine(dataHoraSistema.ToShortTimeString());

//Console.WriteLine(dataHoraSistema.AddDays(1));



//using System.Globalization;

//Console.WriteLine("Digite seu nome");
//string nome = Console.ReadLine();


//Console.WriteLine("Digite sua idade");
//string idade = Console.ReadLine();

//string frase = "Bem vinda  " + nome + " ao curso, você tem " + idade + " anos!";
//Console.WriteLine(frase);

//string frase2 = string.Format("Bem vinda {0}  ao curso, você tem {1} anos!", nome, idade);
//Console.WriteLine(frase2);

//string frase3 = $"Bem vinda {nome} ao curso, voce tem {idade} anos!";
//Console.WriteLine(frase3);

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
//int numeroPaginas = int.Parse(Console.ReadLine());
bool validacao = int.TryParse(Console.ReadLine(), out int numeroPaginas);


Console.WriteLine("Digite a data da publicação: dd/mm/aaaa:");
//DateTime dataPublicacao = DateTime.Parse(Console.ReadLine());
bool validacao2 = DateTime.TryParse(Console.ReadLine(), out DateTime dataPublicacao);

Console.WriteLine("Digite o idioma do livro:");
string idiomaLivro = Console.ReadLine();


Console.Clear();

Console.WriteLine("---- Livro Cadastrado com sucesso! ----");

Console.WriteLine("Livro: " + (tituloLivro.ToUpper()) + "-" + subtituloLivro);

Console.WriteLine("Autor: " + nomeAutor);
Console.WriteLine("Editora: " + nomeEditora);
Console.WriteLine("Detalhes: Publicado em  " + dataPublicacao.ToShortDateString()+ " com " +  numeroPaginas + " páginas em " + idiomaLivro);
Console.WriteLine(validacao);
Console.WriteLine(validacao2);
