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
            foreach (var item in items)
            {
                Console.WriteLine($"Adicionado {item.Quantidade} de {item.Produto.Nome} ao pedido.");
                Produtos.Add(item);
            }
        }
    }
}