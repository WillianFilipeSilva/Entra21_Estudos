namespace ExerciciosCSharp.ExerciciosPOO.SistemaBancario.Objetos.ContaCorrente
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int numeroConta, string titular, double saldo) : base(numeroConta, titular, saldo)
        {
        }

        public override void Sacar(double valor)
        {
            base.Sacar(valor + 5.0);
        }
    }
}