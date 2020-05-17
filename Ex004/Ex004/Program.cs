using System;
using System.Globalization;

namespace Ex004
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados D = new Dados();

            Console.Write("Nome: ");
            D.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            D.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            D.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + D, CultureInfo.InvariantCulture);

            Console.Write("Digite a porcentagem para aumentar o salario ");
            double pct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            D.AumentarSalario(pct);

            Console.WriteLine("Dados atualizados: " + D);

            Console.ReadKey();
        }
    }
}
