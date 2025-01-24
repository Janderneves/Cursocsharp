﻿using System;

namespace Ex020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escolha um número para ver a tabuada: ");

            int numero = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Tabuada do {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
    }
}
