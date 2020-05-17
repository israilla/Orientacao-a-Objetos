using System;
using System.Globalization;

namespace Ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            Info funcionario1, funcionario2;

            funcionario1 = new Info();
            funcionario2 = new Info();

            double salarioM;

            Console.WriteLine("Entre com o nome da primeira pessoa e seu respectivo salário");
            funcionario1.Nome = Console.ReadLine();
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o nome da segunda pessoa e seu respectivo salário");
            funcionario2.Nome = Console.ReadLine();
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.WriteLine("Nome: " + funcionario1.Nome);
            Console.WriteLine("Salário: " + funcionario1.Salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.WriteLine("Nome: " + funcionario2.Nome);
            Console.WriteLine("Salário: " + funcionario2.Salario.ToString("F2", CultureInfo.InvariantCulture));

            salarioM = (funcionario1.Salario + funcionario2.Salario) / 2.0;

            Console.WriteLine("Salário médio = " + salarioM.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
