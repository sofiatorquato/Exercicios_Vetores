using Array0903.Exercicios;


namespace Array0903
{

    class Program
    {

        static void Main(string[] args)
        {


            Console.WriteLine("Informe o número do exercício desejado: ");
            int option = int.Parse(Console.ReadLine());

            switch (option) {

                case 1:
                    Ex1.Executar();
                    break;

                case 2:
                    Ex2.Executar();
                    break;

                case 3:
                    Ex3.Executar();
                    break;

                case 4:
                    Ex4.Executar();
                    break;

            }



        }
    }

}