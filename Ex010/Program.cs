namespace Ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o salário do funcionário: R$ ");
            double salario = Convert.ToDouble(Console.ReadLine());

            double aumento;

            if (salario > 2500)
            {
                aumento = salario * 0.05;
            }
            else if (salario > 1250)
            {
                aumento = salario * 0.10;
            }
            else
            {
                aumento = salario * 0.15;
            }
            double novoSalario = salario + aumento;
            Console.WriteLine("Aumento: R$ " + aumento.ToString("F2"));
            Console.WriteLine("Novo salario: R$ " + novoSalario.ToString("F2"));
        }
    }
}
