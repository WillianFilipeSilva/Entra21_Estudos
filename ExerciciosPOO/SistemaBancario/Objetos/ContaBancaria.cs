namespace ExerciciosCSharp.ExerciciosPOO.SistemaBancario.Objetos
{
    public class ContaBancaria
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

        public ContaBancaria(int numeroConta, string titular, double saldo)
        {
            this._numeroConta = numeroConta;
            this._titular = titular;
            this._saldo = saldo;
        }

        public double Depositar(double valor)
        {
            Saldo += (valor * (1 + PercentualBonusDeposito/100));
            return Saldo;
        }

        public double Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= (valor + TaxaDeSaque);
                return Saldo;
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente na conta: {NumeroConta} - {Titular}");
                return Saldo;
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual da conta: {NumeroConta} - {Titular} | Saldo: R$: {Saldo:F2}");
        }
    }
}