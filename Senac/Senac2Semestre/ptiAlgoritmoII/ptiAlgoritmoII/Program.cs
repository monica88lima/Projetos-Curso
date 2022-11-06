namespace ptiAlgoritmoII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Trabalhando com Vetores!! ------");

            Console.WriteLine(" Digite um número para determinar o tamanho do vetor: ");
            bool verificacao = int.TryParse(Console.ReadLine(), out int tamanhoVetor);

            int[] array = new int[tamanhoVetor];

            for (int i = 0; i < tamanhoVetor; i++)
            {
                Console.WriteLine($" Digite o {i + 1}º número ");
                verificacao = int.TryParse(Console.ReadLine(), out int x);
                array.SetValue(x, i);
            }

            int diferenca = FuncaoDiferenca(array);
            Console.WriteLine("a) Calcule e retorna o valor da maior diferença entre dois elementos distintos no vetor: ");
            Console.WriteLine("Respostas: A maior diferença é " + diferenca);

            bool comparar = CompararArrayCrescente(array);
            Console.WriteLine("b) Verifique se o vetor está em ordem crescente, e retorne true caso esteja e false caso contrario:");
            Console.WriteLine("Resposta: " + comparar);


        }
        public static int FuncaoDiferenca(int[] numeros)
        {
            //essa função pega o maior numero do vetor e o menor e faz uma subtração
            int maiorValor = numeros.Max();
            int menorValor = numeros.Min();
            int diferenca = maiorValor - menorValor;

            return diferenca;
        }

        public static bool CompararArrayCrescente(int[] listNumeros)

        {
            //i = faz a contagem do index, que deve ser limitado pelo tamanho do vetor original.
            // limito a testagem do index até o ultimo elemento do vetor
            //comparo o primeiro com o segundo, o primeiro for maior que o segundo entao a lista nao esta em ordem crescente


            for (int i = 0; i < listNumeros.Length; i++)
            {

                if ((i + 1) < listNumeros.Length)
                {
                    var num1 = listNumeros[i];
                    var num2 = listNumeros[i + 1];
                    if (num1 > num2)
                    {
                        return false;
                    }
                }
            }

            return true;
        }


    }
}