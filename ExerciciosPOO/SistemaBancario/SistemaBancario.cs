using ExerciciosCSharp.ExerciciosPOO.SistemaBancario.Objetos;
using ExerciciosCSharp.ExerciciosPOO.SistemaBancario.Objetos.ContaCorrente;
using ExerciciosCSharp.ExerciciosPOO.SistemaBancario.Objetos.ContaPoupanca;
using System.Linq;
using System.Threading;

namespace ExerciciosCSharp.ExerciciosPOO.SistemaBancario
{
    public class SistemaBancario
    {
        public static List<ContaBancaria> contasCadastradas = new();
        public static Dictionary<int, string> Menu = new()
        {
            { 1, "Cadastrar Conta" },
            { 2, "Exibir Conta" },
            { 3, "Sacar" },
            { 4, "Depositar" },
        };
        public static Dictionary<int, int> TipoConta = new();

        public void Executar()
        {
            try
            {
                int opcao = -1;
                while (opcao != 0)
                {
                    Console.Clear();
                    Console.WriteLine("=== Sistema Bancário ===");
                    foreach (var item in Menu)
                    {
                        Console.WriteLine($"{item.Key} - {item.Value}");
                    }
                    Console.WriteLine("0 - Sair");
                    Console.Write("Digite a opção desejada: ");

                    if (!int.TryParse(Console.ReadLine(), out opcao))
                    {
                        Console.WriteLine("Opção inválida!");
                        Thread.Sleep(2000);
                        continue;
                    }

                    switch (opcao)
                    {
                        case 0:
                            Console.WriteLine("Finalizando...");
                            Thread.Sleep(2000);
                            break;
                        case 1:
                            CadastrarConta();
                            break;
                        case 2:
                            ExibirConta();
                            break;
                        case 3:
                            Sacar();
                            break;
                        case 4:
                            Depositar();
                            break;
                        default:
                            Console.WriteLine("Opção inválida!");
                            Thread.Sleep(2000);
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro: {e.Message}");
            }
        }

        private void CadastrarConta()
        {
            Console.WriteLine("Digite o tipo da conta que deseja cadastrar: 1 - Corrente / 2 - Poupanca");
            if (!int.TryParse(Console.ReadLine(), out int tipo) || (tipo != 1 && tipo != 2))
            {
                Console.WriteLine("Tipo de conta inválido!");
                Thread.Sleep(2000);
                return;
            }

            Console.Write("Digite o número da conta: ");
            var numeroConta = LerVerificarOpcao();
            Console.Write("Digite o nome do titular: ");
            var titular = Console.ReadLine();
            Console.Write("Digite o saldo inicial: ");
            if (!double.TryParse(Console.ReadLine(), out double saldo))
            {
                Console.WriteLine("Saldo inválido!");
                Thread.Sleep(2000);
                return;
            }

            ContaBancaria novaConta;
            if (tipo == 1)
            {
                novaConta = new ContaCorrente(numeroConta, titular, saldo);
            }
            else
            {
                novaConta = new ContaBancaria(numeroConta, titular, saldo);
            }
            contasCadastradas.Add(novaConta);
            TipoConta[numeroConta] = tipo;

            Console.WriteLine("Conta cadastrada com sucesso!");
            Thread.Sleep(2000);
        }

        private void ExibirConta()
        {
            Console.Write("Digite o número da conta que deseja exibir: ");
            var numeroConta = LerVerificarOpcao();
            var conta = contasCadastradas.FirstOrDefault(x => x.NumeroConta == numeroConta);
            if (conta == null)
            {
                Console.WriteLine("Conta não encontrada!");
                Thread.Sleep(2000);
                return;
            }
            conta.ExibirSaldo();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        private void Sacar()
        {
            Console.Write("Digite o número da conta: ");
            var numeroConta = LerVerificarOpcao();
            var conta = contasCadastradas.FirstOrDefault(x => x.NumeroConta == numeroConta);
            if (conta == null)
            {
                Console.WriteLine("Conta não encontrada!");
                Thread.Sleep(2000);
                return;
            }
            Console.Write("Digite o valor para saque: ");
            if (!double.TryParse(Console.ReadLine(), out double valor))
            {
                Console.WriteLine("Valor inválido!");
                Thread.Sleep(2000);
                return;
            }
            conta.Sacar(valor);
            Console.WriteLine("Operação de saque realizada!");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        private void Depositar()
        {
            Console.Write("Digite o número da conta: ");
            var numeroConta = LerVerificarOpcao();
            var conta = contasCadastradas.FirstOrDefault(x => x.NumeroConta == numeroConta);
            if (conta == null)
            {
                Console.WriteLine("Conta não encontrada!");
                Thread.Sleep(2000);
                return;
            }
            Console.Write("Digite o valor para depósito: ");
            if (!double.TryParse(Console.ReadLine(), out double valor))
            {
                Console.WriteLine("Valor inválido!");
                Thread.Sleep(2000);
                return;
            }

            if (TipoConta.ContainsKey(numeroConta) && TipoConta[numeroConta] == 2)
            {
                conta.Depositar(valor);
                conta.Depositar(valor * 0.05);
            }
            else
            {
                conta.Depositar(valor);
            }
            Console.WriteLine("Operação de depósito realizada!");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        private int LerVerificarOpcao()
        {
            int numeroConta = -1;
            while (numeroConta <= 0)
            {
                if (!int.TryParse(Console.ReadLine(), out numeroConta))
                {
                    Console.WriteLine("Digite um número válido!");
                    Thread.Sleep(1000);
                }
            }
            return numeroConta;
        }
    }
}