using ExerciciosCSharp.ExerciciosPOO.BancoComInterface.Interfaces;

namespace ExerciciosCSharp.ExerciciosPOO.BancoComInterface.Objetos.ContaCorrente
{
    public class ContaCorrente : IContaBancaria
    {
        public void Depositar() { }

        public void Depositar(double valor)
        {
            throw new NotImplementedException();
        }

        public void Sacar() { }

        public void Sacar(double valor)
        {
            throw new NotImplementedException();
        }
    }
}