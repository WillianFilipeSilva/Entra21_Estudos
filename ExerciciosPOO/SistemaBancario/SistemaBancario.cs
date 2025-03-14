using ExerciciosCSharp.ExerciciosPOO.SistemaBancario.Objetos.ContaCorrente;
using ExerciciosCSharp.ExerciciosPOO.SistemaBancario.Objetos.ContaPoupanca;

namespace ExerciciosCSharp.ExerciciosPOO.SistemaBancario
{
    public class SistemaBancario
    {
        public void Executar() 
        {
            try
            {
                ContaCorrente contaCorrente = new ContaCorrente(123, "João Silva", 1000);
                contaCorrente.Depositar(500);
                contaCorrente.Sacar(200);
                contaCorrente.ExibirSaldo();

                ContaPoupanca caontaPoupanca = new ContaPoupanca(456, "Maria Souza", 2000);
                caontaPoupanca.Depositar(1000);
                caontaPoupanca.Sacar(500);
                caontaPoupanca.ExibirSaldo();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro: { e}");
            }
        }
    }
}