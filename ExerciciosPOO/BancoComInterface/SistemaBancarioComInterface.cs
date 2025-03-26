using ExerciciosCSharp.ExerciciosPOO.BancoComInterface.Interfaces;
using ExerciciosCSharp.ExerciciosPOO.BancoComInterface.Objetos.ContaPoupanca;

namespace ExerciciosCSharp.ExerciciosPOO.BancoComInterface
{
    public class SistemaBancarioComInterface
    {
        public void Executar()
        {
            try
            {
               
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro: {e}");
            }
        }

        static void ExibirConta(IContaBancaria conta)
        {
            Console.WriteLine("");
        }
    }
}