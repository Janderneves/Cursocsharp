using System;

namespace Ex030
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123"; // Senha correta
            string SenhaDigitada; // Senha digitada pelo usuário    
            int tentativa = 0; // Contador de tentativas

            // Loop para solicitar a senha do usuário

            do
            {
                Console.Clear();
                Console.Write("Digite a senha: ");
                SenhaDigitada = Console.ReadLine();
                tentativa++; // Incrementa o contador de tentativas

                // Verifica se a senha digitada é diferente da senha correta
                if (SenhaDigitada != senha && tentativa < 3)
                {
                    Console.WriteLine("Senha incorreta!");
                    Console.WriteLine("Você ainda tem " + (3 - tentativa) + " tentativa(s)");
                    Console.ReadKey();
                }
                else if (SenhaDigitada != senha && tentativa == 3)
                {
                    Console.WriteLine("Senha incorreta! Seu Acesso está bloqueado! ");
                    return;
                }

            }while (SenhaDigitada != senha);

            Console.Clear();
            Console.WriteLine("Senha correta! - Tentativas: "+ tentativa);  
        }
    }
}
