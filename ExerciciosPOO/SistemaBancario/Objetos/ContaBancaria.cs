namespace ExerciciosCSharp.ExerciciosPOO.SistemaBancario.Objetos
{
    public class ContaBancaria
    {
        private int numeroConta;
        private string titular;
        private double saldo;

        public int NumeroConta => numeroConta;
        public string Titular
        {
            get => titular;
            set => titular = value;
        }
        public double Saldo
        {
            get => saldo;
            protected set => saldo = value;
        }

        public ContaBancaria(int numeroConta, string titular, double saldo)
        {
            this.numeroConta = numeroConta;
            this.titular = titular;
            this.saldo = saldo;
        }

        public virtual void Depositar(double valor)
        {
            Saldo += valor;
        }

        public virtual void Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente na conta: {NumeroConta} - {Titular}");
            }
        }

        public void ExibirSaldo()
        {
            var nomeConta = this.GetType().Name == "ContaCorrente"? "conta corrente" : "conta poupanca";
            Console.WriteLine($"Saldo atual da {nomeConta}: - {Titular} | Saldo: R$: {Saldo:F2}");
        }
    }
}