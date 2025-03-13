namespace ExerciciosCSharp.ExerciciosPOO.Lanchonete.Objetos.Pedido
{
    public class Pedido
    {
        public int Id { get; set; }

        public List<Item.Item> Produtos;

        public double PrecoTotal => Produtos.Sum(item => item.Preco);

        public Pedido(int numero)
        {
            Id = numero;
            Produtos = new List<Item.Item>();
        }

        public void InserirItems(List<Item.Item> items)
        {
            Console.WriteLine($"Adicionando produtos ao Pedido {Id}:");
            foreach (var item in items)
            {
                Console.WriteLine($"Adicionado {item.Quantidade} unidades de {item.Produto.Nome}.");
                Produtos.Add(item);
            }
            Console.WriteLine();
        }

        public void ExibirItems()
        {
            Console.WriteLine($"\n<------------------ Pedido {Id} ------------------>\n");
            foreach (var item in Produtos)
            {
                Console.WriteLine($"Pedido {Id} - {item.Quantidade} de {item.Produto.Nome} - {item.Preco:f2}R$.");
            }
            Console.WriteLine($"\nO preço total do seu pedido é: {PrecoTotal:f2}R$.\n");
            Console.WriteLine("<---------------------------------------------->\n");
        }
    }
}