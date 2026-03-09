namespace Array0903.Exercicios
{
    internal class Ex3
    {
        public static void Executar() {


            int[] numero = new int[6];

            for (int i = 0; i < numero.Length; i++) {

                Console.WriteLine($"Informe o {i + 1}º número: ");
                numero[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numero.Length / 2; i++) {

                int aux = numero[i];
                numero[i] = numero[numero.Length - 1 - i];
                numero[numero.Length - 1 - i] = aux;
            }

            Console.WriteLine("Vetor invertido:");
            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine(numero[i]);
            }
        }

    }
}
