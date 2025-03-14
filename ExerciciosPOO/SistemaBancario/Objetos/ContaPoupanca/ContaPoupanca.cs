namespace ExerciciosCSharp.ExerciciosPOO.SistemaBancario.Objetos.ContaPoupanca
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(int numeroConta, string titular, double saldo) : base(numeroConta, titular, saldo)
        {
        }

        public override void Depositar(double valor)
        {
            base.Depositar(valor + (valor * 0.005));
        }
    }
}