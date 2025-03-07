namespace ExerciciosCSharp.ExerciciosPOO.Objetos.Item
{
    public class Item
    {
        public long id { get; set; }

        public Produto.Produto Produto { get; set; }

        public int Quantidade { get; set; }

        public double Preco => Produto.Preco * Quantidade;

        public Item(Produto.Produto produto, int quantidade)
        {
            this.id = produto.Id;
            this.Produto = produto;
            this.Quantidade = quantidade;
        }
    }
}