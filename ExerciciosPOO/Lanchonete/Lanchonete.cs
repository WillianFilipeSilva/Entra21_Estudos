using ExerciciosCSharp.ExerciciosPOO.Objetos.Item;
using ExerciciosCSharp.ExerciciosPOO.Objetos.Pedido;
using ExerciciosCSharp.ExerciciosPOO.Objetos.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosCSharp.ExerciciosPOO.Principal
{
    public class Lanchonete
    {
        public void Executar()
        {
            var  Cardapio = new Dictionary<int, Produto>()
            {
                { 1, new("X-Burguer", 12.00) },
                { 2, new("X-Salada", 14.00) },
                { 3, new("X-Bacon", 16.00) },
                { 4, new("X-Tudo", 20.00) },
                { 5, new("X-Frango", 15.00) },
                { 6, new("Hambúrguer simples", 10.00) },
                { 7, new("Cheeseburguer", 11.50) },

                { 8, new("Batata frita pequena", 8.00) },
                { 9, new("Batata frita média", 12.00) },
                { 10, new("Batata frita grande", 16.00) },

                { 11, new("Refrigerante lata", 6.00) },
                { 12, new("Refrigerante 600ml", 8.00) },
                { 13, new("Suco natural", 10.00) },
                { 14, new("Água", 4.00) },

                { 15, new("Milkshake pequeno", 10.00) },
                { 16, new("Milkshake médio", 14.00) },
                { 17, new("Milkshake grande", 18.00) }
            };

            var carrinho = AdicionarItemsNoCarrinho(Cardapio);

            Pedido pedido1 = new(1);
            pedido1.InserirProdutos(carrinho);

            Console.WriteLine($"O preço do seu pedido é: {pedido1.PrecoTotal}R$");
        }

        private static void ExibirCardapio(Dictionary<int, Produto> cardapio)
        {
            Console.WriteLine("<---------------- Cardápio ---------------->");

            foreach (var item in cardapio)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Nome} - {item.Value.Preco}R$");
            }

            Console.WriteLine("<----------------    <3    ---------------->");
        }

        private static List<Item> AdicionarItemsNoCarrinho(Dictionary<int, Produto> cardapio)
        {
            try
            {
                ExibirCardapio(cardapio);

                var carrinho = new List<Item>();

                var opcao = -2;
                while (opcao != 0 || opcao == -1)
                {
                    Console.Write("Digite a opção do produto, 0 para finalizar, ou -1 para remover produto ou quantidade adicionado: ");
                    opcao = int.Parse(Console.ReadLine());

                    if (opcao == -1)
                    {
                        Console.Write("Digite a opção do produto que deseja remover: ");
                        opcao = int.Parse(Console.ReadLine());

                        if (carrinho.Contains(item: carrinho[opcao - 1]))
                        {
                            Console.WriteLine($"Tem {carrinho[opcao - 1].Quantidade} unidades no carrinho, digite a quantidade que deseja remover, ou digite 0 para remover tudo: ");
                            var quantidade = int.Parse(Console.ReadLine());

                            if (quantidade < carrinho[opcao - 1].Quantidade)
                            {
                                Console.WriteLine($"Removido {quantidade} unidades de {carrinho[opcao - 1].Produto.Nome} do carrinho.");
                                carrinho[opcao - 1].Quantidade -= quantidade;
                            }
                            else
                            {
                                if(quantidade == carrinho[opcao - 1].Quantidade)
                                {
                                    Console.WriteLine($"Removido {carrinho[opcao - 1].Produto.Nome} do carrinho.");
                                } 
                                else
                                {
                                    Console.WriteLine($"A quantidade digitara é maior que a do carrinho, removido {carrinho[opcao - 1].Produto.Nome} do carrinho. ");
                                }
                                 carrinho.RemoveAt(opcao - 1);
                            }
                        } 
                    }
                    else if (opcao != 0)
                    {
                        Console.WriteLine($"Digite a quantidade de {cardapio[opcao].Nome}: ");
                        var quantidade = int.Parse(Console.ReadLine());

                        carrinho.Add(new Item(cardapio[opcao], quantidade));

                        Console.WriteLine($"Adicionado {quantidade} unidades de {cardapio[opcao].Nome} no carrinho.");
                    }
                }
                if (carrinho.Count == 0)
                    throw new Exception("Nenhum item foi adicionado ao carrinho.");

                return carrinho;
            }
            catch (Exception e)
            {
                throw new Exception($"Ocorreu um erro ao adicionar os itens no carrinho: {e}");
            }
        }
    }
}