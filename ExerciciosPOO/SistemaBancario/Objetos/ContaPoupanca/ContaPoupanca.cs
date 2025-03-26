namespace ExerciciosCSharp.ExerciciosPOO.SistemaBancario.Objetos.ContaPoupanca
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(int numeroConta, string titular, double saldo) : base(numeroConta, titular, saldo)
        {
            PercentualBonusDeposito = 5;
        }
    }
}