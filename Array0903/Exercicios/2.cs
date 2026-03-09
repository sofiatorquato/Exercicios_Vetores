using System.Globalization;

namespace Array0903.Exercicios
{
    internal class Ex2
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("EXERCÍCIO 2");
            Console.WriteLine();
            Console.WriteLine("Peça para o usuário informar 10 números reais (double)." +
            " O programa deve identificar e exibir qual foi o maior e qual foi o menor número digitado dentro do vetor.");
            Console.WriteLine();
            Thread.Sleep(1000);

            double[] x = new double[10];
            double maior = double.MinValue;
            double menor = double.MaxValue;


            for (int i = 0; i < x.Length; i++)
            {
                
                Console.WriteLine($"Informe o {i + 1}º número: ");
                x[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (x[i] > maior) {
                    maior = x[i];
                }

                if (x[i] < menor) { 
                    menor = x[i];
                }
            }

            Console.WriteLine($"Maior: {maior.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Menor: {menor.ToString("F2",CultureInfo.InvariantCulture)}");


        }


    }
}
