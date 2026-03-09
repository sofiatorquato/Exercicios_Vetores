namespace Array0903.Exercicios
{
    internal class Ex4
    {
        public static void Executar()
        {

            int[] numero = { 58, 69, 23, 454, 65, 15, 0, 54 };


            Console.WriteLine("Informe o número que procura: ");
            int alvo = int.Parse(Console.ReadLine());
            bool encontrado = false;
            int i = 0;



            for (i = 0; i < numero.Length; i++)
            {

                if (numero[i] == alvo)
                {
                    encontrado = true;
                    break;

                }
            }

            if (encontrado == true)
            {
                Console.WriteLine($"ACHEI! O número {alvo} está na posição {i}");

            }

            else
            {
                Console.WriteLine("Número não encontrado no índice.");
            }
        }

    }
}
