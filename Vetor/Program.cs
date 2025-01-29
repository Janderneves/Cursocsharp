namespace Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] num = new int[5];

              num[0] = 10;
              num[1] = 20;
              num[2] = 30;
              num[3] = 40;
              num[4] = 50;


              Console.WriteLine(num[2]);

              int[] n = new int[5] { 60, 70, 80, 90, 100 };

              Console.WriteLine(n[0]);

              int[] numero = { 65, 25, 84, 76, 12, 8 };

              Console.WriteLine(numero[3]); 
            *
            Random random = new Random();

            int[] vetor = new int[10];

            for (int i = 0; i < 10; i++)
            {
                vetor[i] = random.Next(1, 100);
                Console.WriteLine(vetor[i]);
            }

            Console.WriteLine();

            double[] reais = new double[10];

            for (int i = 0; i < 10; i++)
            {
                reais[i] = random.NextDouble() * 1000;
                Console.WriteLine(reais[i].ToString("C2"));
        } */
            string[] nome = { "Maria", "João", "Carlos", "Pedro", "Ana", "José" };

            for (int i = 0; i < nome.Length; i++)
            {
                if(i < nome.Length - 1)
                {
                    Console.Write(nome[i] + ", ");
                }
                else
                {
                    Console.WriteLine(nome[i] + ". ");
                }
            }

        }
    }
}
