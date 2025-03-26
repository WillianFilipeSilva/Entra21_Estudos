using ExerciciosCSharp.ExerciciosPOO.BancoComInterface.Interfaces;

namespace ExerciciosCSharp.ExerciciosPOO.BancoComInterface.Objetos.ContaBancariaBase
{
    public class ContaBancariaBase : IContaBancaria
    {
        private int _numeroConta;
        private string _titular;
        private double _saldo;
        private double _taxaDeSaque;
        private double _percentualBonusDepósito;

        public int NumeroConta => _numeroConta;

        public string Titular
        {
            get => _titular;
            set => _titular = value;
        }

        public double Saldo
        {
            get => _saldo;
            protected set => _saldo = value;
        }

        public double TaxaDeSaque
        {
            get => _taxaDeSaque;
            protected set => _taxaDeSaque = value;
        }

        public double PercentualBonusDeposito
        {
            get => _percentualBonusDepósito;
            protected set => PercentualBonusDeposito = value;
        }

        public ContaBancariaBase(int numeroConta, string titular, double saldo)
        {
            this._numeroConta = numeroConta;
            this._titular = titular;
            this._saldo = saldo;
        }

        public void Depositar(double valor)
        {
            throw new NotImplementedException();
        }

        public void Sacar(double valor)
        {
            throw new NotImplementedException();
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual da conta: {NumeroConta} - {Titular} | Saldo: R$: {Saldo:F2}");
        }
    }
}