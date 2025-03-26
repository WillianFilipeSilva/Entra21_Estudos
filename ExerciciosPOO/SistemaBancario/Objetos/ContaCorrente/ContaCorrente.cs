namespace ExerciciosCSharp.ExerciciosPOO.SistemaBancario.Objetos.ContaCorrente
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int numeroConta, string titular, double saldo) : base(numeroConta, titular, saldo)
        {
            TaxaDeSaque = 5;
        }
    }
}