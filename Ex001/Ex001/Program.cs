using System;

namespace Ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados pessoa1, pessoa2;

            pessoa1 = new Dados();
            pessoa2 = new Dados();

            Console.Write("Digite o nome da primeira pessoa: ");
            pessoa1.nome = Console.ReadLine();
            Console.Write("Digite a idade da primeira pessoa: ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da segunda pessoa: ");
            pessoa2.nome = Console.ReadLine();
            Console.Write("Digite a idade da segunda pessoa: ");
            pessoa2.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa ");
            Console.WriteLine("Nome: " + pessoa1.nome);
            Console.WriteLine("Idade: " + pessoa1.idade);

            Console.WriteLine("Dados da segunda pessoa");
            Console.WriteLine("Nome: " + pessoa2.nome);
            Console.WriteLine("Idade: " + pessoa2.idade);

            if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa1.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa2.nome);
            }

            Console.ReadKey();
        }
    }
}
