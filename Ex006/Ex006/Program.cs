using System;
using System.Globalization;

namespace Ex006
{
    class Program
    {
        static void Main(string[] args)
        {
            DadosAluno DA = new DadosAluno();


            Console.Write("Nome do Aluno: " + DA.Nome);
            DA.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            DA.NotaPrimeiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            DA.NotaSegundoTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            DA.NotaTerceiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + DA.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (DA.Aprovado() == true)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM: " + DA.Restante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }

            Console.ReadKey();  
        }
    }
}
