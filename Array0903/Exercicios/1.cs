using System.Globalization;

namespace Array0903.Exercicios
{
    internal class Ex1
    {
        public static void Executar()
        {

            Console.WriteLine("EXERCÍCIO 1");
            Console.WriteLine();
            Console.WriteLine("Crie um programa que peça ao usuário para digitar 5 números inteiros. " +
                "Armazene-os em um vetor e, ao final, exiba a soma de todos os valores e a média aritmética simples.");
            Console.WriteLine();
            Thread.Sleep(1000);

            int[] numero = new int[5];
            int soma = 0;

            for (int i = 0; i < numero.Length; i++) { 
            
                Console.WriteLine($"Informe o {i+1}º número: ");
                numero[i] = int.Parse( Console.ReadLine() );
            
            }
            for (int i = 0; i < numero.Length; i++) {

                
                Console.WriteLine($"{numero[i]}");
                soma = soma + numero[i];
            }

            Console.Clear();
            Console.WriteLine($"Soma: {soma}");

            double mediaArit = (double)soma/numero.Length; //(double) faz a conversão para que não há o truncamento de dados

            Console.WriteLine($"Média Aritmética: {mediaArit.ToString("F2", CultureInfo.InvariantCulture)}");
        }

    }
}
