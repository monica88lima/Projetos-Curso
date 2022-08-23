// See https://aka.ms/new-console-template for more information
double valorGasolina;
double valorAlcool;
double calculador;
string mensagem = "S";


while (mensagem.ToUpper() == "S")

{
    Console.WriteLine("Digite o valor do litro da GASOLINA: ");
    valorGasolina = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor do litro da ALCOOL: ");
    valorAlcool = double.Parse(Console.ReadLine());

    calculador = valorAlcool / valorGasolina;
    calculador = Math.Round(calculador, 1);

    if (calculador == 0.7)
    {
        Console.WriteLine("Tanto faz o Combustivel escolhido");
    }
    else
    {
        if (calculador > 0.7)
        {
            Console.WriteLine("Abasteça com Gasolina");
        }
        else
        {
            Console.WriteLine("Abasteça com ALCOOL ");
        }
    }

    Console.WriteLine("Deseja efetuar um novo CALCULO?. Digite S para sim ou pressione qualquer letra para sair.");
    mensagem = Console.ReadLine();

}


Console.WriteLine("Finalizado");

