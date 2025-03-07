namespace ExerciciosCSharp.ExerciciosPOO.Lanchonete.Objetos.Produto
{
    public class Produto
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(long id, string nome, double preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }
    }
}