using System;
using System.Collections.Generic;
using System.Globalization;
using ExerciciosCSharp.ExerciciosPOO.LoucadoraDeVeiculos.Objetos.Veiculo.Carro;
using ExerciciosCSharp.ExerciciosPOO.LoucadoraDeVeiculos.Objetos.Veiculo.Caminhao;
using ExerciciosCSharp.ExerciciosPOO.LoucadoraDeVeiculos.Objetos.Veiculo.Moto;
using ExerciciosCSharp.ExerciciosPOO.LoucadoraDeVeiculos.Objetos.Veiculo.VeiculoBase;
using ExerciciosCSharp.ExerciciosPOO.LoucadoraDeVeiculos.Interfaces;

namespace ExerciciosCSharp.ExerciciosPOO.LoucadoraDeVeiculos
{
    public class LocadoraDeVeiculos
    {
        private List<IVeiculo> veiculos = new List<IVeiculo>();

        public void Executar()
        {
            try
            {
                int opcao;
                do
                {
                    Console.WriteLine("===== Locadora de Veículos =====");
                    Console.WriteLine("1 - Cadastrar Veículo");
                    Console.WriteLine("2 - Listar Veículos Cadastrados");
                    Console.WriteLine("3 - Alugar Veículo");
                    Console.WriteLine("0 - Sair");
                    Console.Write("Escolha uma opção: ");

                    if (!int.TryParse(Console.ReadLine(), out opcao))
                    {
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        continue;
                    }

                    switch (opcao)
                    {
                        case 1:
                            CadastrarVeiculo();
                            break;
                        case 2:
                            ListarVeiculos();
                            break;
                        case 3:
                            AlugarVeiculo();
                            break;
                        case 0:
                            Console.WriteLine("Saindo do sistema...");
                            break;
                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }

                    Console.WriteLine();
                } while (opcao != 0);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro: {e.Message}");
            }
        }

        private void CadastrarVeiculo()
        {
            Console.WriteLine("===== Cadastro de Veículo =====");
            Console.WriteLine("Selecione o tipo de veículo:");
            Console.WriteLine("1 - Carro");
            Console.WriteLine("2 - Moto");
            Console.WriteLine("3 - Caminhão");
            Console.Write("Opção: ");
            int tipo;
            if (!int.TryParse(Console.ReadLine(), out tipo))
            {
                Console.WriteLine("Opção inválida!");
                return;
            }

            Console.Write("Informe o modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Informe a marca: ");
            string marca = Console.ReadLine();
            Console.Write("Informe o ano: ");
            int ano;
            if (!int.TryParse(Console.ReadLine(), out ano))
            {
                Console.WriteLine("Ano inválido!");
                return;
            }
            Console.Write("Informe o valor da diária: ");
            double valorDiaria;
            if (!double.TryParse(Console.ReadLine(), out valorDiaria))
            {
                Console.WriteLine("Valor inválido!");
                return;
            }

            IVeiculo veiculo = null;
            switch (tipo)
            {
                case 1:
                    veiculo = new Carro(modelo, marca, ano, valorDiaria);
                    break;
                case 2:
                    veiculo = new Moto(modelo, marca, ano, valorDiaria);
                    break;
                case 3:
                    veiculo = new Caminhao(modelo, marca, ano, valorDiaria);
                    break;
                default:
                    Console.WriteLine("Tipo de veículo inválido!");
                    return;
            }
            veiculos.Add(veiculo);
            Console.WriteLine("Veículo cadastrado com sucesso!");
        }

        private void ListarVeiculos()
        {
            Console.WriteLine("===== Veículos Cadastrados =====");
            if (veiculos.Count == 0)
            {
                Console.WriteLine("Nenhum veículo cadastrado.");
                return;
            }
            int index = 1;
            foreach (var v in veiculos)
            {
                Console.WriteLine($"{index} - {((VeiculoBase)v).GetDetalhes()}");
                index++;
            }
        }

        private void AlugarVeiculo()
        {
            Console.WriteLine("===== Alugar Veículo =====");
            if (veiculos.Count == 0)
            {
                Console.WriteLine("Nenhum veículo cadastrado para aluguel.");
                return;
            }
            ListarVeiculos();
            Console.Write("Selecione o veículo pelo número: ");
            int indice;
            if (!int.TryParse(Console.ReadLine(), out indice) || indice < 1 || indice > veiculos.Count)
            {
                Console.WriteLine("Opção inválida!");
                return;
            }
            var veiculo = veiculos[indice - 1];
            Console.Write("Informe a quantidade de dias para o aluguel: ");
            int dias;
            if (!int.TryParse(Console.ReadLine(), out dias))
            {
                Console.WriteLine("Quantidade de dias inválida!");
                return;
            }
            double custo = veiculo.CalcularAluguel(dias);
            Console.WriteLine($"{((VeiculoBase)veiculo).GetDetalhes()} | Custo do aluguel para {dias} dias: {custo.ToString("C", new CultureInfo("pt-BR"))}");
        }
    }
}