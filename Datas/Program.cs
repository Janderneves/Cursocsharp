﻿namespace Datas
{
    internal class Program
    {
        static void Main(string[] args)
        {  /*
            string[] frutas = { "maça", "banana", "uva", "carambola", "melancia", "ameixa", "jambo", "manga", "kiwi", "abacaxi" };
            double[] preço = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            for (int i = 0; i < grutas.Length; i++)
            {
                Console.WriteLine("O mês de " + meses[i] + " tem " + dias[i] + "dias.");
            }

            string[] semana = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };

            foreach (string dia in semana)
            {
                Console.WriteLine(dia);



            }*/

            int[] numeros = { 10, 45, 22, 50, 6, -84, -2, 91, -23 };

            Console.WriteLine(numeros.First());
            Console.WriteLine(numeros.Last());
            Console.WriteLine();
            Console.WriteLine(numeros.Max());
            Console.WriteLine(numeros.Min());
            Console.WriteLine(numeros.Average());

        }
    }
}
