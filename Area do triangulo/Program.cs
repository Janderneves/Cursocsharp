namespace Area_do_triangulo
{
    internal class Program
    {
        static void Main(string[] args)
     using System;

    {
        static void Main()
        {
            
            Console.Write("Digite o valor da base do triângulo: ");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());

            
            Console.Write("Digite o valor da altura do triângulo: ");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

            double area = (baseTriangulo * alturaTriangulo) / 2;

            
            Console.WriteLine($"A área do triângulo é: {area}");
        }
    }