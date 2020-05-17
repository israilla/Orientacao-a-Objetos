using System;
using System.Globalization;

namespace Ex008
{
    class Program
    {
        static void Main(string[] args)
        {
            AbrirConta conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com o nome do títular da Conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá deposito inicial (s/n): ");
            char resp = char.Parse(Console.ReadLine());

            if (resp != 's' && resp != 'n')
            {
                Console.Write("Erro. Digite apenas 's' ou 'n' ");
                Environment.Exit(0);
            }

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new AbrirConta(numero, titular, depositoInicial);
            }
            else
            {
                conta = new AbrirConta(titular, numero);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
            Console.ReadKey();
        }
    }
}
