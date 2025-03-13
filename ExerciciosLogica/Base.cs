namespace ExerciciosCSharp.ExerciciosLogica
{
    public class Base
    {
        public Dictionary<int, (string, Action)> lista = new();

        public virtual void Executar() { }

        public virtual void ExibirMenu(Dictionary<int, (string, Action)> opcoes)
        {
            int opcao = -1;

            while (opcao != 0)
            {
                try
                {
                    Console.WriteLine("Selecione o exercício que deseja executar:");

                    foreach (var item in opcoes)
                    {
                        Console.WriteLine($"{item.Key}. {item.Value.Item1}");
                    }

                    Console.WriteLine("0. Sair");
                    Console.Write("Digite a opção desejada: ");

                    if (!int.TryParse(Console.ReadLine(), out opcao))
                    {
                        Console.WriteLine("Entrada inválida. Tente novamente.");
                        continue;
                    }

                    if (opcoes.ContainsKey(opcao))
                    {
                        try
                        {
                            opcoes[opcao].Item2();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro ao executar a opção {opcao}: {ex.Message}");
                        }
                    }
                    else if (opcao != 0)
                    {
                        Console.WriteLine("Opção inválida. Tente novamente.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
                }

                Console.WriteLine("Pressione qualquer tecla para reiniciar o programa.");
                Console.ReadLine();
            }
            Console.WriteLine("Encerrando o programa.");
        }

        public virtual void Exercicio1() { }
        public virtual void Exercicio2() { }
        public virtual void Exercicio3() { }
        public virtual void Exercicio4() { }
        public virtual void Exercicio5() { }
        public virtual void Exercicio6() { }
        public virtual void Exercicio7() { }
        public virtual void Exercicio8() { }
        public virtual void Exercicio9() { }
        public virtual void Exercicio10() { }
        public virtual void Exercicio11() { }
        public virtual void Exercicio12() { }
        public virtual void Exercicio13() { }
        public virtual void Exercicio14() { }
        public virtual void Exercicio15() { }
        public virtual void Exercicio16() { }
        public virtual void Exercicio17() { }
        public virtual void Exercicio18() { }
        public virtual void Exercicio19() { }
        public virtual void Exercicio20() { }
        public virtual void Exercicio21() { }
        public virtual void Exercicio22() { }
        public virtual void Exercicio23() { }
        public virtual void Exercicio24() { }
    }
}