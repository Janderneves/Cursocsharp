using System.Runtime.InteropServices;

namespace Ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro para ver sua tabuada");
            // Lê o número do usuário
            int numero;
            while (!intTryParse(Console.ReadLine(), out numero));

            Console.WriteLine("Entrada inválida, Por favor, insira um número inteiro:");

            // Exibe a tabuada
            Console.WriteLine($"\nTabuada do número {numero}:");
            for (int i = 1; i <= 10; i++);
            Console.WriteLine($"{numero} x {i} = {numero * i}");

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();


        }
    }
}
