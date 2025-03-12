namespace ExerciciosCSharp.ExerciciosPOO.Lanchonete.Objetos.Item
{
    public class Item
    {
        public long Id { get; set; }

        public Produto.Produto Produto { get; set; }

        public int Quantidade { get; set; }

        public double Preco => Produto.Preco * Quantidade;

        public Item(Produto.Produto produto, int quantidade)
        {
            Id = produto.Id;
            Produto = produto;
            Quantidade = quantidade;
        }
    }
}