using System;
using System.Globalization;

namespace Ex008
{
    class AbrirConta
    {
        public string Nome { get; private set; }
        public int NumeroConta { get; set; }
        public double Saldo { get; private set; }

        //construtor padrão
        public AbrirConta()
        {
        }
        public AbrirConta(string nome, int numeroConta)
        {
            Nome = nome;
            NumeroConta = numeroConta;
        }
        public AbrirConta(int numeroConta, string nome, double saldo) : this(nome, numeroConta)
        {
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta: "
            + NumeroConta.ToString()
            + ", Títular: "
            + Nome
            + ", Saldo: R$ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
