// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercicio 8!");
Console.WriteLine(" Digite sua altura: ");
double altura = double.Parse(Console.ReadLine());

Console.WriteLine(" Digite seu peso: ");
double peso = double.Parse(Console.ReadLine());

Console.WriteLine(" Digite seu sexo, sendo F para feminino e M para Masculino: ");
string sexo = (Console.ReadLine());
sexo = sexo.ToUpper();

double calculoImc = peso / Math.Pow(altura, 2);
calculoImc = Math.Round(calculoImc, 2);

if (sexo == "F")
{
    if (calculoImc < 19)
    {
        Console.WriteLine("Abaixo do Normal");
    }
    else if (calculoImc >= 19 && calculoImc <= 23.9)
    {
        Console.WriteLine("Normal");
    }
    else if (calculoImc >= 24 && calculoImc <= 28.9)
    {
        Console.WriteLine("Obesidade Leve");
    }
    else if (calculoImc >= 29 && calculoImc <= 38.9)
    {
        Console.WriteLine("Obesidade Moderada");
    }
    else
    {
        Console.WriteLine("Obesidade Morbida");
    }
}

else if (sexo == "M")
{
    if (calculoImc < 20)
    {
        Console.WriteLine("Abaixo do Normal");
    }
    else if (calculoImc >= 20 && calculoImc <= 24.9)
    {
        Console.WriteLine("Normal");
    }
    else if (calculoImc >= 25 && calculoImc <= 29.9)
    {
        Console.WriteLine("Obesidade Leve");
    }
    else if (calculoImc >= 30 && calculoImc <= 39.9)
    {
        Console.WriteLine("Obesidade Moderada");
    }
    else
    {
        Console.WriteLine("Obesidade Morbida");
    }

}

Console.WriteLine("Seu IMC: "+ calculoImc);
Console.WriteLine(sexo);
