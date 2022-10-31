// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercicio 3 ");

Console.WriteLine(" Digite a temperatura: ");
double temperatura = double.Parse(Console.ReadLine());  

if(temperatura >= 41)
{
    Console.WriteLine("A SITUAÇÃO PARA SUA TEMPERATURA É: HIPERTERMIA");
}
else if(temperatura >= 39.6 && temperatura < 41)
{
    Console.WriteLine("A SITUAÇÃO PARA SUA TEMPERATURA É: FEBRE ALTA!");
}
else if (temperatura >= 37.6 && temperatura < 39.6)
{
    Console.WriteLine("A SITUAÇÃO PARA SUA TEMPERATURA É: FEBRE!");
}
else if (temperatura >= 36 && temperatura < 37.6)
{
    Console.WriteLine("A SITUAÇÃO PARA SUA TEMPERATURA É: NORMAL!");
}
else
{
    
    Console.WriteLine("A SITUAÇÃO PARA SUA TEMPERATURA É: HIPOTERMIA!");
    
}
