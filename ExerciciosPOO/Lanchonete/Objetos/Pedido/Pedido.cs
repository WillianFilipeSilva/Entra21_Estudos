namespace ExerciciosCSharp.ExerciciosPOO.Lanchonete.Objetos.Pedido
{
    public class Pedido
    {
        public long Numero { get; set; }

        public List<Item.Item> Produtos;

        public double PrecoTotal => Produtos.Sum(item => item.Preco);

        public Pedido(long numero)
        {
            Numero = numero;
            Produtos = new List<Item.Item>();
        }

        public void InserirProdutos(List<Item.Item> items)
        {
            Console.WriteLine($"Adicionando produtos ao Pedido {Numero}:");
            foreach (var item in items)
            {
                Console.WriteLine($"Adicionado {item.Quantidade} unidades de {item.Produto.Nome}.");
                Produtos.Add(item);
            }
            Console.WriteLine("");
        }

        public void ExibirItems()
        {
            Console.WriteLine($"\n<------------------ Pedido {Numero} ------------------>\n");
            foreach (var item in Produtos)
            {
                Console.WriteLine($"Pedido {Numero} - {item.Quantidade} de {item.Produto.Nome} - {item.Preco:f2}R$.");
            }
            Console.WriteLine($"\nO preço total do seu pedido é: {PrecoTotal:f2}R$.\n");
            Console.WriteLine("<---------------------------------------------->\n");
        }
    }
}