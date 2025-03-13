using ExerciciosCSharp.ExerciciosPOO.Lanchonete.Objetos.Item;
using ExerciciosCSharp.ExerciciosPOO.Lanchonete.Objetos.Pedido;
using ExerciciosCSharp.ExerciciosPOO.Lanchonete.Objetos.Produto;

namespace ExerciciosCSharp.ExerciciosPOO.Principal
{
    public class Lanchonete
    {
        public static List<Pedido> pedidosRealizados = new();

        public static List<Produto> cardapio = new()
        {
            new(1, "X-Burguer", 12.00),
            new(2, "X-Salada", 14.00),
            new(3, "X-Bacon", 16.00),
            new(5, "X-Frango", 15.00),
            new(6, "Hambúrguer simples", 10.00),
            new(7, "Cheeseburguer", 11.50),
            new(8, "Batata frita pequena", 8.00),
            new(9, "Batata frita média", 12.00),
            new(10, "Batata frita grande", 16.00),
            new(11, "Refrigerante lata", 6.00),
            new(12, "Refrigerante 600ml", 8.00),
            new(13, "Suco natural", 10.00),
            new(14, "Água", 4.00),
            new(15, "Milkshake pequeno", 10.00),
            new(16, "Milkshake médio", 14.00),
            new(17, "Milkshake grande", 18.00)
        };

        public void Executar()
        {
            Console.WriteLine("Digite a opção que voce deseja: ");

            var opcao = -1;
            while (opcao != 0)
            {
                Console.WriteLine("1 - Cadastrar pedido\n2 - Exibir pedido\n3 - Exibir todos os pedidos\n0 - Sair");
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida!");
                    opcao = -1;
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
                        CadastrarPedido();
                        break;
                    case 2:
                        ExibirPedido();
                        break;
                    case 3:
                        ExibirPedidos();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Thread.Sleep(2000);
                        continue;
                }
            }

            //Pedido 1
            //CadastrarPedido(cardapio);
            Pedido pedido1 = new(1);
            pedido1.InserirItems(new List<Item>()
            {
                new Item(cardapio[0], 2),
                new Item(cardapio[1], 1),
                new Item(cardapio[2], 1),
            });
            pedido1.ExibirItems();

            //Pedido 2
            //CadastrarPedido(cardapio);
            Pedido pedido2 = new(2);
            pedido2.InserirItems(new List<Item>()
            {
                new Item(cardapio[3], 2),
                new Item(cardapio[4], 1),
                new Item(cardapio[5], 1),
            });
            pedido2.ExibirItems();
        }

        private static void ExibirCardapio()
        {
            Console.WriteLine("\n<---------------- Cardápio ---------------->");
            foreach (var produto in cardapio)
            {
                Console.WriteLine($"{produto.Id} - {produto.Nome} - {produto.Preco:C}");
            }
            Console.WriteLine("<----------------    <3    ---------------->\n");
        }

        private static void ExibirPedido(int? idPedido = null)
        {
            if (idPedido == null)
            {
                while (true)
                {
                    Console.WriteLine("Digite o ID do pedido que deseja exibir, ou 0 para voltar.");
                    if (!int.TryParse(Console.ReadLine(), out var pedidoId))
                    {
                        Console.WriteLine("Entrada inválida! Digite um número válido.");
                        Thread.Sleep(2000);
                        continue;
                    }

                    if (pedidoId == 0)
                        return;

                    idPedido = pedidoId;
                    break;
                }
            }
            var pedido = pedidosRealizados.FirstOrDefault(p => p.Id == idPedido);
            if (pedido == null)
            {
                Console.WriteLine($"Não foi encontrado nenhum pedido com o ID {idPedido}.");
                Thread.Sleep(2000);
                return;
            }
            pedido.ExibirItems();
        }

        private static void ExibirPedidos()
        {
        Console.WriteLine("\n<---------------- Pedidos ---------------->\n");
        foreach (var pedido in pedidosRealizados)
        {
            ExibirPedido(pedido.Id);
        }
        Console.WriteLine("\n<----------------    <3    ---------------->");
        }

        private static List<Item> InserirItemsNoCarrinho()
        {
            ExibirCardapio();
            var carrinho = new List<Item>();

            while (true)
            {
                Console.Write("Digite a opção do produto (0 para finalizar, -1 para remover produto): ");
                if (!int.TryParse(Console.ReadLine(), out int opcao))
                {
                    Console.WriteLine("Entrada inválida! Digite um número válido.");
                    Thread.Sleep(2000);
                    continue;
                }

                if (opcao == 0)
                    break;

                if (opcao == -1)
                {
                    carrinho = RemoverQuantidadeOuItemDoCarrinho(carrinho);
                    Thread.Sleep(2000);
                    continue;
                }

                var produto = cardapio.FirstOrDefault(p => p.Id == opcao);
                if (produto == null)
                {
                    Console.WriteLine("Opção inválida! Escolha um item do cardápio.");
                    Thread.Sleep(2000);
                    continue;
                }

                Console.Write($"Digite a quantidade de {produto.Nome}: ");
                if (!int.TryParse(Console.ReadLine(), out int quantidade) || quantidade <= 0)
                {
                    Console.WriteLine("Quantidade inválida! Digite um número positivo.");
                    Thread.Sleep(2000);
                    continue;
                }

                var item = carrinho.FirstOrDefault(i => i.Produto.Id == produto.Id);
                if (item == null)
                    carrinho.Add(new Item(produto, quantidade));
                else
                    item.Quantidade += quantidade;

                Console.WriteLine($"Adicionado {quantidade} unidades de {produto.Nome} ao carrinho.");
            }

            return carrinho;
        }

        private static List<Item> RemoverQuantidadeOuItemDoCarrinho(List<Item> carrinho)
        {
            if (carrinho.Count == 0)
            {
                Console.WriteLine("O carrinho está vazio! Nada para remover.");
                return carrinho;
            }

            Console.Write("Digite a opção do produto que deseja remover: ");
            if (!int.TryParse(Console.ReadLine(), out int opcao))
            {
                Console.WriteLine("Entrada inválida! Digite um número válido.");
                return carrinho;
            }

            var item = carrinho.FirstOrDefault(i => i.Produto.Id == opcao);
            if (item == null)
            {
                Console.WriteLine("Este item não está no carrinho.");
                return carrinho;
            }

            Console.Write($"Tem {item.Quantidade} unidades no carrinho. Digite a quantidade para remover (0 para remover tudo): ");
            if (!int.TryParse(Console.ReadLine(), out int quantidade) || quantidade < 0)
            {
                Console.WriteLine("Quantidade inválida! Digite um número válido.");
                return carrinho;
            }

            if (quantidade == 0 || quantidade >= item.Quantidade)
            {
                carrinho.Remove(item);
                Console.WriteLine($"Removido {item.Produto.Nome} do carrinho.");
            }
            else
            {
                item.Quantidade -= quantidade;
                Console.WriteLine($"Removido {quantidade} unidades de {item.Produto.Nome}. Restam {item.Quantidade} unidades.");
            }

            return carrinho;
        }

        private void CadastrarPedido()
        {
            var carrinho = InserirItemsNoCarrinho();
            if (carrinho.Any())
            {
                Pedido pedido = new(pedidosRealizados.Count + 1);
                pedido.InserirItems(carrinho);

                if (pedido.Produtos.Count == 0)
                {
                    Console.WriteLine($"Pedido {pedido.Id} - Nenhum produto foi adicionado ao pedido.");
                    return;
                }
                pedidosRealizados.Add(pedido);

                pedido.ExibirItems();
                return;
            }

            Console.WriteLine("O Carrinho está vazio! Nenhum pedido foi realizado.");
        }
    }
}