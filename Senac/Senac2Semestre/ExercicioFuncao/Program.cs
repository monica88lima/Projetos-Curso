using System.Reflection.Metadata.Ecma335;

namespace ExercicioFuncao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            bool verificação = int.TryParse(Console.ReadLine(), out int numDigitado);

            int numDobrado = Dobro(numDigitado);

            int resultado =  Fatorial(numDobrado);

            Console.WriteLine($"O dobro de {numDigitado} é {numDobrado} e o fatorial deste é {resultado}");
        }


        public static int Fatorial(int numero)
        {
            var fatorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                fatorial = i * fatorial;
            }
            return fatorial;
        }

        public static int Dobro(int num)
        {
            int calculo = num * 2;
            return calculo;
        }
        


    }
}