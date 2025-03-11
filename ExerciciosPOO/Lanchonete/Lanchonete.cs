using ExerciciosCSharp.ExerciciosPOO.Lanchonete.Objetos.Item;
using ExerciciosCSharp.ExerciciosPOO.Lanchonete.Objetos.Pedido;
using ExerciciosCSharp.ExerciciosPOO.Lanchonete.Objetos.Produto;

namespace ExerciciosCSharp.ExerciciosPOO.Principal
{
    public class Lanchonete
    {
        List<Pedido> pedidosRealizados = new();

        List<Produto> cardapio = new()
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
            //Pedido 1
            //CadastrarPedido(cardapio);
            Pedido pedido1 = new(1);
            pedido1.InserirProdutos(new List<Item>()
            {
                new Item(cardapio[0], 2),
                new Item(cardapio[1], 1),
                new Item(cardapio[2], 1),
            });
            pedido1.ExibirItems();

            //Pedido 2
            //CadastrarPedido(cardapio);
            Pedido pedido2 = new(2);
            pedido2.InserirProdutos(new List<Item>()
            {
                new Item(cardapio[3], 2),
                new Item(cardapio[4], 1),
                new Item(cardapio[5], 1),
            });
            pedido2.ExibirItems();
        }

        private static void ExibirCardapio(List<Produto> cardapio)
        {
            Console.WriteLine("\n<---------------- Cardápio ---------------->");
            foreach (var produto in cardapio)
            {
                Console.WriteLine($"{produto.Id} - {produto.Nome} - {produto.Preco:C}");
            }
            Console.WriteLine("<----------------    <3    ---------------->\n");
        }

        private static List<Item> AdicionarItemsNoCarrinho(List<Produto> cardapio)
        {
            ExibirCardapio(cardapio);
            var carrinho = new List<Item>();

            while (true)
            {
                Console.Write("Digite a opção do produto (0 para finalizar, -1 para remover produto): ");
                if (!int.TryParse(Console.ReadLine(), out int opcao))
                {
                    Console.WriteLine("Entrada inválida! Digite um número válido.");
                    continue;
                }

                if (opcao == 0)
                    break;

                if (opcao == -1)
                {
                    carrinho = RemoverQuantidadeOuItemDoCarrinho(carrinho);
                    continue;
                }

                var produto = cardapio.FirstOrDefault(p => p.Id == opcao);
                if (produto == null)
                {
                    Console.WriteLine("Opção inválida! Escolha um item do cardápio.");
                    continue;
                }

                Console.Write($"Digite a quantidade de {produto.Nome}: ");
                if (!int.TryParse(Console.ReadLine(), out int quantidade) || quantidade <= 0)
                {
                    Console.WriteLine("Quantidade inválida! Digite um número positivo.");
                    continue;
                }

                var item = carrinho.FirstOrDefault(i => i.Produto.Id == produto.Id);
                if (item == null)
                    carrinho.Add(new Item(produto, quantidade));
                else
                    item.Quantidade += quantidade;

                Console.WriteLine($"Adicionado {quantidade} unidades de {produto.Nome} ao carrinho.");
            }

            if (carrinho.Count == 0)
                Console.WriteLine("Nenhum item foi adicionado ao carrinho.");

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

        private void CadastrarPedido(List<Produto> cardapio)
        {
            var carrinho = AdicionarItemsNoCarrinho(cardapio);

            if (carrinho.Count > 0)
            {
                Pedido pedido = new(pedidosRealizados.Count + 1);
                pedido.InserirProdutos(carrinho);

                if (pedido.Produtos.Count == 0)
                {
                    Console.WriteLine($"Pedido {pedido.Numero} - Nenhum produto foi adicionado ao pedido.");
                    return;
                }
                pedidosRealizados.Add(pedido);

                pedido.ExibirItems();
            }
            else
            {
                Console.WriteLine("O Carrinho está vazio! Nenhum pedido foi realizado.");
            }
        }
    }
}