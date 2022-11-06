using System.Runtime.Intrinsics.X86;

namespace codingTankAula3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //    double[] notas = new double[4];
            //    double somaNotas = 0;
            //    double mediaNotas = 0;
            //    var mensagem = "";

            //    for (int contador = 0; contador < notas.Length; contador++)
            //    {
            //        Console.WriteLine($"Digite a {contador + 1}° nota: ");

            //        bool validacao = double.TryParse(Console.ReadLine(), out notas[contador]);

            //        if (validacao)
            //        {
            //            somaNotas += notas[contador];
            //        }
            //        else
            //        {
            //            Console.WriteLine("Você digitou um valor invalido: ");
            //            contador--;
            //        }

            //    }

            //    mediaNotas = somaNotas / notas.Length;

            //    bool aprovado = mediaNotas >= 7;

            //    if (aprovado)
            //    {
            //        mensagem = $"Aprovado sua média foi {Math.Round(mediaNotas, 2)}";
            //    }
            //    else
            //    {
            //        Console.WriteLine("Digite a nota da sua recuperação: ");
            //        double notaRecuperacao = double.Parse(Console.ReadLine());

            //        double mediaRecuperacao = (mediaNotas + notaRecuperacao) / 2;

            //        aprovado = mediaRecuperacao >= 7;
            //        mensagem = $"Você foi {(aprovado ? "Aprovado" : "Reprovado")} na Recuperação, sua média foi {Math.Round(mediaRecuperacao, 2)}";

            //    }

            //    Console.WriteLine(mensagem);


            //bool aprovado = mediaNotas >= 7;

            //if (aprovado)
            //{
            //    Console.WriteLine($"Aprovado sua média foi {Math.Round(mediaNotas, 2)}");
            //}
            //else
            //{
            //    Console.WriteLine("Digite a nota da sua recuperação: ");
            //    double notaRecuperacao = double.Parse(Console.ReadLine());

            //    double mediaRecuperacao = (mediaNotas + notaRecuperacao) / 2;

            //    if (mediaRecuperacao >= 7)
            //    {
            //        Console.WriteLine($" Você foi Aprovado na Recuperação, sua média foi {Math.Round(mediaRecuperacao, 2)}");
            //        return;
            //    }

            //    Console.WriteLine($"Você foi Reprovado na recuperação, sua média foi {Math.Round(mediaRecuperacao, 2)}");

            //}









            //Console.WriteLine(notas.Count());
            //Console.WriteLine(somaNotas);


            ////Exercicio 1 
            //Console.WriteLine("Digite a primeira nota: ");
            //double nota1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite a segunda nota: ");
            //double nota2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite a terceira nota: ");
            //double nota3 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite a quarta nota: ");
            //double nota4 = double.Parse(Console.ReadLine());

            //double media = (nota1 + nota2 + nota3 + nota4) / 4;

            //if(media >= 7)
            //{
            //    Console.WriteLine($"Aprovado sua média foi {media}");
            //}
            //else 
            //{
            //    Console.WriteLine("Digite a nota da sua recuperação: ");
            //    double notaRecuperação = double.Parse(Console.ReadLine());

            //    media =( media + notaRecuperação) / 2;

            //    if(media >= 7)
            //    {
            //        Console.WriteLine($"Aprovado sua média foi {Math.Round(media,2)}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Você foi Reprovado na recuperação, sua média foi {Math.Round(media,2)}");

            //    }

            //}
            //exercicio 2
            string mensagem = "";
            Console.WriteLine("Qual o valor (pago) pelo produto:");
            double valorPago = double.Parse(Console.ReadLine());
            double valorVenda = 0.0;
            if (valorPago < 20.00)
            {
                valorVenda = (valorPago * 0.45) + valorPago;
                mensagem = $"O valor da venda será R$ {Math.Round(valorVenda, 2)}";
            }
            else
            {
                valorVenda = (valorPago * 0.30) + valorPago;
                mensagem = $"O valor da venda será R$ {Math.Round(valorVenda, 2)}";

            }
            Console.WriteLine(mensagem);

        }


    }
}