namespace Caixa_Eletronico
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-------------------");
            Console.WriteLine("CAIXA ELETRÔNICO");
            Console.WriteLine("-------------------");
            Console.WriteLine("");

            Console.WriteLine("Gostaria de realizar um saque? (S/N): ");
            string resposta = Console.ReadLine();

            while (resposta != "S" && resposta != "N")
            {
                Console.WriteLine("");
                Console.WriteLine("Digite uma resposta válida!");
                Console.WriteLine("Gostaria de realizar um saque? (S/N): ");
                resposta = Console.ReadLine();
            }

            while (resposta == "S")
            {
                Console.Write("Digite o valor do saque: ");

                int dinheiro;

                while (!int.TryParse(Console.ReadLine(), out dinheiro) || dinheiro <= 0)
                {
                    Console.WriteLine("Valor inválido!");
                    Console.Write("Digite o valor do saque: ");
                }

                int resto = dinheiro;

                int notas_200 = resto / 200;

                resto = resto % 200;

                int notas_100 = resto / 100;

                resto = resto % 100;

                int notas_50 = resto / 50;

                resto = resto % 50;

                int notas_20 = resto / 20;

                resto = resto % 20;

                Console.WriteLine("");
                Console.WriteLine("Você receberá: ");
                Console.WriteLine("");


                if (notas_200 > 0)
                {
                    Console.WriteLine($"Notas de R$ 200: {notas_200}");
                }

                if (notas_100 > 0)
                {
                    Console.WriteLine($"Notas de R$ 100: {notas_100}");
                }

                if (notas_50 > 0)
                {
                    Console.WriteLine($"Notas de R$ 50: {notas_50}");
                }

                if (notas_20 > 0)
                {
                    Console.WriteLine($"Notas de R$ 20: {notas_20}");
                }

                Console.WriteLine("");
                Console.WriteLine("Gostaria de realizar outro saque? (S/N)");
                resposta = Console.ReadLine();

                while (resposta != "S" && resposta != "N")
                {
                    Console.WriteLine("Digite uma resposta valida!");
                    Console.WriteLine("Gostaria de realizar um saque? (S/N): ");
                    resposta = Console.ReadLine();
                }


            }
        }
    }
}
