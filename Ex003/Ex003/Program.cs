using System;
using System.Globalization;

namespace Ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo C;

            C = new Calculo();

            Console.Write("Entre com a altura do retângulo: ");
            C.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com a largura do retângulo: ");
            C.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("AREA = " + C.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + C.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + C.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
