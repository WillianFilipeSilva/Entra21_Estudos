using ExerciciosCSharp.ExerciciosPOO.BancoComInterface.Interfaces;
using System.Security.Cryptography.X509Certificates;

namespace ExerciciosCSharp.ExerciciosPOO.BancoComInterface.Objetos.ContaPoupanca
{
    public class ContaPoupanca : IContaBancaria
    {
        public ContaPoupanca(int numeroConta)
        {
            _numeroConta = numeroConta;

        }

        public int NumeroConta => _numeroConta;

        public void Depositar(double valor)
        {
            throw new NotImplementedException();
        }

        public void Sacar(double valor)
        {
            throw new NotImplementedException();
        }

        public static void exibirconta(IContaBancaria conta)
        {
            Console.WriteLine($"conta: {conta.}");
        }
    }
}