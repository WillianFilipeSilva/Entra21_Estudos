namespace ExerciciosCSharp.ExerciciosPOO.LoucadoraDeVeiculos.Objetos.Veiculo.Caminhao
{
    public class Caminhao : VeiculoBase.VeiculoBase
    {
        public Caminhao(string modelo, string marca, int ano, double valorDiaria) : base(modelo, marca, ano, valorDiaria) { }

        public override double CalcularAluguel(int dias)
        {
            if (dias < 0)
            {
                Console.WriteLine($"Quantidade {dias} não é válida.");
                return 0;
            }
            return (dias * ValorDiaria) * 1.2;
        }
    }
}